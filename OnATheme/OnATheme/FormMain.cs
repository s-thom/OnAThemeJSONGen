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
                listBoxModels.Items.Clear();
                foreach (Model m in selectedBlock.Models)
                {
                    listBoxModels.Items.Add(m);
                }
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
                labelWeight.Enabled = true;
                numericUpDownModelWeight.Enabled = true;
                numericUpDownModelWeight.Value = selectedModel.Weight;
            }
            catch
            {
                Console.WriteLine("A block might have been deleted");
            }
        }
        /// <summary>
        /// Change the weight of the selected model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownModelWeight_ValueChanged(object sender, EventArgs e)
        {
            if (selectedModel != null)
            {
                selectedModel.Weight = (int)numericUpDownModelWeight.Value;
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
                numericUpDownModelWeight.Enabled = false;
                labelWeight.Enabled = false;
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
            Directory.CreateDirectory(@"OaT/assets/minecraft/models/block/");
            Directory.CreateDirectory(@"OaT/assets/minecraft/blockstates/");

            foreach (Block b in Blocks)
            {
                b.CreateBlockModels();
                b.CreateBlockstates();
            }
            File.WriteAllText(@"OaT/assets/minecraft/models/block/none.json", Properties.Resources.none);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/cross_tint.json", Properties.Resources.cross_tint);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/double_cross.json", Properties.Resources.double_cross);
            File.WriteAllText(@"OaT/assets/minecraft/models/block/double_cross_tint.json", Properties.Resources.double_cross_tint);
        }
    }
}
