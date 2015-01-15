using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OnATheme
{
    public partial class FormMain : Form
    {
        List<Block> Blocks = new List<Block>();

        Block selectedBlock;
        BlockVariant selectedVariant;
        Model selectedModel;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add a block to the pack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pull up forms and get a new block
            Block NewBlock = FormAddBlock.ShowAndReturnObject();
            if (NewBlock != null)
            {
                Blocks.Add(NewBlock);
                listBoxBlocks.Items.Add(NewBlock);
            }
        }
        /// <summary>
        /// Select a block
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Select the highlighted block
                selectedBlock = (Block)listBoxBlocks.Items[listBoxBlocks.SelectedIndex];
                listBoxVariants.Items.Clear();
                foreach (BlockVariant b in selectedBlock.BlockVariants)
                    listBoxVariants.Items.Add(b);

                removeBlockToolStripMenuItem.Enabled = true;
            }
            catch
            {
                Console.WriteLine("A block might have been deleted");
            }
        }
        /// <summary>
        /// Select an attribute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxVariants_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Select the highlighted variant
                selectedVariant = (BlockVariant)listBoxVariants.Items[listBoxVariants.SelectedIndex];
                listBoxModels.Items.Clear();
                foreach (Model m in selectedVariant.Models)
                    listBoxModels.Items.Add(m);

            }
            catch
            {
                Console.WriteLine("A block might have been deleted");
            }
        }
        /// <summary>
        /// Select a model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Select the highlighed model
                selectedModel = (Model)listBoxModels.Items[listBoxModels.SelectedIndex];
                splitContainerAttribute.Panel2.Enabled = true;

                if (selectedModel is ModelCompound)
                {
                    // Enable all compound related items
                    splitToolStripMenuItem.Enabled = true;
                    groupBoxCompoundSpecific.Enabled = true;
                    groupBoxModelSpecific.Enabled = false;
                    numericUpDownEstimate.Value = (selectedModel as ModelCompound).NumModels;
                }
                else if (selectedModel is ModelIndividual)
                {
                    // Enable all individual related items
                    splitToolStripMenuItem.Enabled = false;
                    groupBoxCompoundSpecific.Enabled = false;
                    groupBoxModelSpecific.Enabled = true;
                    numericUpDownEstimate.Value = 1;
                }

                // Set rotations
                checkBoxX0.Checked = selectedModel.XRotation[0];
                checkBoxX90.Checked = selectedModel.XRotation[1];
                checkBoxX180.Checked = selectedModel.XRotation[2];
                checkBoxX270.Checked = selectedModel.XRotation[3];

                checkBoxY0.Checked = selectedModel.YRotation[0];
                checkBoxY90.Checked = selectedModel.YRotation[1];
                checkBoxY180.Checked = selectedModel.YRotation[2];
                checkBoxY270.Checked = selectedModel.YRotation[3];
                // Set UV lock
                checkBoxUVLock.Checked = selectedModel.UVLock;
            }
            catch
            {
                Console.WriteLine("A block might have been deleted");
            }
        }
        /// <summary>
        /// Remove the selected block
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to remove the selected block
            if (selectedBlock != null)
            {
                Blocks.Remove(selectedBlock);
                listBoxBlocks.Items.Remove(selectedBlock);
                listBoxVariants.Items.Clear();
                listBoxModels.Items.Clear();
                splitContainerAttribute.Panel2.Enabled = false;
                // Removing all selected references, just in case.
                selectedBlock = null;
                selectedVariant = null;
                selectedModel = null;
                removeBlockToolStripMenuItem.Enabled = false;
                splitToolStripMenuItem.Enabled = false;
            }
        }
        /// <summary>
        /// Close the thing down. Very simple.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // What a line.
            this.Close();
        }
        /// <summary>
        /// Create the JSON files in the OaT folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createUnZippedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Feedback! (Might atually be seen if there are a lot of models)
            this.Cursor = Cursors.WaitCursor;

            // Create directories
            Directory.CreateDirectory(@"OaT/assets/minecraft/models/block/");
            Directory.CreateDirectory(@"OaT/assets/minecraft/blockstates/");
            // Create the files!
            foreach (Block b in Blocks)
            {
                b.CreateJSON();
            }
            this.Cursor = Cursors.Default;
        }
        /// <summary>
        /// Update the rotations for the selected model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateRotations_Click(object sender, EventArgs e)
        {
            // Set rotations
            bool[] xRot = new bool[4] { checkBoxX0.Checked, checkBoxX90.Checked, checkBoxX180.Checked, checkBoxX270.Checked };
            bool[] yRot = new bool[4] { checkBoxY0.Checked, checkBoxY90.Checked, checkBoxY180.Checked, checkBoxY270.Checked };

            selectedModel.XRotation = xRot;
            selectedModel.YRotation = yRot;
            // Set UV Lock
            selectedModel.UVLock = checkBoxUVLock.Checked;
        }
        /// <summary>
        /// Split compound models into individual objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Normal models can't be split
            if (selectedModel is ModelCompound)
            {
                // Make sure it's going to work on the right model
                if (selectedVariant.Models.Contains(selectedModel))
                {
                    selectedVariant.Models = (selectedModel as ModelCompound).ConvertToIndividualModels();
                    listBoxModels.Items.Clear();
                    foreach (Model m in selectedVariant.Models)
                        listBoxModels.Items.Add(m);
                    listBoxModels.SelectedIndex = 0;
                }
                else
                {
                    Console.WriteLine("Please select the right variant before proceding");
                }
            }
            else
            {
                Console.WriteLine("Tried to convert converted model");
            }
        }
        /// <summary>
        /// Crate built in models
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBuiltinBaseModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create directory
            Directory.CreateDirectory(@"OaT/assets/minecraft/models/block/");
            // Create files
            File.WriteAllText(@"OaT/assets/minecraft/models/block/none.json", Properties.Resources.none);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/cross_tint.json", Properties.Resources.cross_tint);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/double_cross.json", Properties.Resources.double_cross);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/double_cross_tint.json", Properties.Resources.double_cross_tint);
        }
        /// <summary>
        /// Change model weight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {
            if (selectedModel is ModelIndividual)
                (selectedModel as ModelIndividual).Weight = (int)numericUpDownWeight.Value;
        }
    }
}
