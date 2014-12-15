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
        public FormAddBlock()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Close the form with a positive result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// Show the dialogue, and return a Block object
        /// </summary>
        /// <returns></returns>
        public static BlockOLD ShowAndReturnObject() 
        {
            FormAddBlock dialog = new FormAddBlock();
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                BlockOLD newBlock = new BlockOLD(dialog.textBoxBlockName.Text, (int)dialog.numericUpDownVariants.Value, dialog.textBoxTextureName.Text, dialog.comboBoxType.Text);
                return newBlock;
            }
            else
            {
               return null; // In case of canceled dialogue
            }
        }
    }
}
