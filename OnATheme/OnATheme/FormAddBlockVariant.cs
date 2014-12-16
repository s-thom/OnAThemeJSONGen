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
    public partial class FormAddBlockVariant : Form
    {
        List<Texture> Textures = new List<Texture>();

        public FormAddBlockVariant()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show the dialogue, and return an Attribute object
        /// </summary>
        /// <returns></returns>
        public static BlockVariant ShowAndReturnObject(string BlockName)
        {
            FormAddBlockVariant dialog = new FormAddBlockVariant();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.textBoxOverwrite.Text != "")
                    BlockName = dialog.textBoxOverwrite.Text;
                BlockVariant newBlock = new BlockVariant(dialog.textBoxName.Text, dialog.textBoxParentModel.Text, BlockName, dialog.Textures, (int)dialog.numericUpDownVariants.Value, dialog.checkBoxCreateModels.Checked);
                return newBlock;
            }
            else
            {
                return null; // In case of canceled dialogue
            }
        }

        private void buttonAddTexture_Click(object sender, EventArgs e)
        {
            Textures.Add(new Texture(textBoxRef.Text, textBoxTexture.Text));
            listBoxTextures.Items.Add(Textures[Textures.Count - 1]);
        }
    }
}
