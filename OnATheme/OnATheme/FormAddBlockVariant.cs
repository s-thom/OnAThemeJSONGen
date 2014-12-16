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

                bool[] xRot = new bool[4] { dialog.checkBoxX0.Checked, dialog.checkBoxX90.Checked, dialog.checkBoxX180.Checked, dialog.checkBoxX270.Checked };
                bool[] yRot = new bool[4] { dialog.checkBoxY0.Checked, dialog.checkBoxY90.Checked, dialog.checkBoxY180.Checked, dialog.checkBoxY270.Checked };

                BlockVariant newBlock = new BlockVariant(dialog.textBoxName.Text, dialog.textBoxParentModel.Text, BlockName, dialog.Textures, (int)dialog.numericUpDownVariants.Value, dialog.checkBoxCreateModels.Checked, xRot, yRot);
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
