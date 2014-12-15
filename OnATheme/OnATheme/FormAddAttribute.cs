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
    public partial class FormAddAttribute : Form
    {
        List<Texture> Textures = new List<Texture>();

        public FormAddAttribute()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show the dialogue, and return an Attribute object
        /// </summary>
        /// <returns></returns>
        public static Attribute ShowAndReturnObject()
        {
            FormAddAttribute dialog = new FormAddAttribute();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Attribute newBlock = new Attribute(dialog.textBoxName.Text, dialog.textBoxParentModel.Text, dialog.Textures, (int)dialog.numericUpDownVariants.Value);
                return newBlock;
            }
            else
            {
                return null; // In case of canceled dialogue
            }
        }

        private void buttonAddTexture_Click(object sender, EventArgs e)
        {
            Textures.Add(new Texture(textBoxRef.Text, textBoxName.Text));
            listBoxTextures.Items.Add(Textures[Textures.Count - 1]);
        }
    }
}
