using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnATheme
{
    public partial class FormAddBlock : Form
    {
        List<BlockVariant> Variants = new List<BlockVariant>();

        public FormAddBlock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show the dialogue, and return a Block object
        /// </summary>
        /// <returns></returns>
        public static Block ShowAndReturnObject() 
        {
            FormAddBlock dialog = new FormAddBlock();
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                Block newBlock = new Block(dialog.textBoxBlockName.Text, dialog.Variants);
                return newBlock;
            }
            else
            {
               return null; // In case of canceled dialogue
            }
        }
        /// <summary>
        /// Add a new variant to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBlockVariant_Click(object sender, EventArgs e)
        {
            BlockVariant newVariant = FormAddBlockVariant.ShowAndReturnObject(textBoxBlockName.Text);
            if (newVariant != null)
            {
                Variants.Add(newVariant);
                listBoxBlockVariants.Items.Add(newVariant);
            }
        }
    }
}
