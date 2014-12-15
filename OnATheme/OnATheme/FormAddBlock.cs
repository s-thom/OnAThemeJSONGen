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
        List<Attribute> Attributes = new List<Attribute>();

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
                Block newBlock = new Block(dialog.textBoxBlockName.Text, dialog.Attributes);
                return newBlock;
            }
            else
            {
               return null; // In case of canceled dialogue
            }
        }

        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {
            Attribute newAttribute = FormAddAttribute.ShowAndReturnObject();
            if (newAttribute != null)
            {
                Attributes.Add(newAttribute);
                listBoxAttributes.Items.Add(newAttribute);
            }
        }
    }
}
