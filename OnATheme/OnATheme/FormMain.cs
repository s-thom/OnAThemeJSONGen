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
                selectedBlock = (Block)listBoxBlocks.Items[listBoxBlocks.SelectedIndex];
                listBoxVariants.Items.Clear();
                foreach (BlockVariant b in selectedBlock.BlockVariants)
                    listBoxVariants.Items.Add(b);
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
                selectedModel = (Model)listBoxModels.Items[listBoxModels.SelectedIndex];
                splitContainerAttribute.Panel2.Enabled = true;

                if (selectedModel is ModelCompound)
                {
                    splitToolStripMenuItem.Enabled = true;
                    groupBoxCompoundSpecific.Enabled = true;
                    groupBoxModelSpecific.Enabled = false;
                    numericUpDownEstimate.Value = (selectedModel as ModelCompound).NumModels;
                }
                else
                {
                    splitToolStripMenuItem.Enabled = false;
                    groupBoxCompoundSpecific.Enabled = false;
                    groupBoxModelSpecific.Enabled = true;
                    numericUpDownEstimate.Value = (selectedModel as ModelCompound).NumModels;
                }

                checkBoxX0.Checked = selectedModel.XRotation[0];
                checkBoxX90.Checked = selectedModel.XRotation[1];
                checkBoxX180.Checked = selectedModel.XRotation[2];
                checkBoxX270.Checked = selectedModel.XRotation[3];

                checkBoxY0.Checked = selectedModel.YRotation[0];
                checkBoxY90.Checked = selectedModel.YRotation[1];
                checkBoxY180.Checked = selectedModel.YRotation[2];
                checkBoxY270.Checked = selectedModel.YRotation[3];

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
            if (selectedBlock != null)
            {
                Blocks.Remove(selectedBlock);
                listBoxBlocks.Items.Remove(selectedBlock);
                listBoxModels.Items.Clear();
                splitContainerAttribute.Panel2.Enabled = false;
            }
        }
        /// <summary>
        /// Close the thing down. Very simple.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Create the JSON files in the OaT folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createUnZippedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Directory.CreateDirectory(@"OaT/assets/minecraft/models/block/");
            Directory.CreateDirectory(@"OaT/assets/minecraft/blockstates/");

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
            bool[] xRot = new bool[4] { checkBoxX0.Checked, checkBoxX90.Checked, checkBoxX180.Checked, checkBoxX270.Checked };
            bool[] yRot = new bool[4] { checkBoxY0.Checked, checkBoxY90.Checked, checkBoxY180.Checked, checkBoxY270.Checked };

            selectedModel.XRotation = xRot;
            selectedModel.YRotation = yRot;
            selectedModel.UVLock = checkBoxUVLock.Checked;
        }

        private void splitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedModel is ModelCompound)
            {
                selectedVariant.Models = (selectedModel as ModelCompound).ConvertToIndividualModels();
                listBoxModels.Items.Clear();
                foreach (Model m in selectedVariant.Models)
                    listBoxModels.Items.Add(m);
                listBoxModels.SelectedIndex = 0;
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
            Directory.CreateDirectory(@"OaT/assets/minecraft/models/block/");
            File.WriteAllText(@"OaT/assets/minecraft/models/block/none.json", Properties.Resources.none);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/cross_tint.json", Properties.Resources.cross_tint);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/double_cross.json", Properties.Resources.double_cross);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/double_cross_tint.json", Properties.Resources.double_cross_tint);
        }

        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {
            selectedModel.Weight = (int)numericUpDownWeight.Value;
        }
    }
}
