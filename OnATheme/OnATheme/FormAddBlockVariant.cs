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
        List<TextureGroup> TextureGroups = new List<TextureGroup>();
        List<string> TGTextures = new List<string>();
        List<string> TGFaces = new List<string>();

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
                
                bool[] xRot = new bool[4] { dialog.checkBoxX0.Checked, dialog.checkBoxX90.Checked, dialog.checkBoxX180.Checked, dialog.checkBoxX270.Checked };
                bool[] yRot = new bool[4] { dialog.checkBoxY0.Checked, dialog.checkBoxY90.Checked, dialog.checkBoxY180.Checked, dialog.checkBoxY270.Checked };

                string modelName  = dialog.textBoxParentModel.Text;
                if (dialog.textBoxOverwrite.Text != "")
                    modelName  = dialog.textBoxOverwrite.Text;

                ModelCompoundExponential m = new ModelCompoundExponential(modelName, dialog.textBoxParentModel.Text, dialog.TextureGroups, xRot, yRot);

                BlockVariant newBlock = new BlockVariant(dialog.textBoxName.Text, m);
                return newBlock;
            }
            else
            {
                return null; // In case of canceled dialogue
            }
        }
        /// <summary>
        /// Add a texture to be added to the texture group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTexture_Click(object sender, EventArgs e)
        {
            TGTextures.Add(Texture.TEXTURE_PATH + textBoxTexture.Text);
            listBoxTextures.Items.Add(TGTextures[TGTextures.Count - 1]);
        }
        /// <summary>
        /// Add a reference to be added to the faces for a texture group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRef_Click(object sender, EventArgs e)
        {
            TGFaces.Add(textBoxRef.Text);
            listBoxFaces.Items.Add(TGFaces[TGFaces.Count - 1]);
        }
        /// <summary>
        /// Open the github.io page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelInstructions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://git.secretonline.co/OnAThemeJSONGen/");
        }
        /// <summary>
        /// Turn the strings into a texture group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTextureGroup_Click(object sender, EventArgs e)
        {
            if (TGFaces.Count > 0 && TGTextures.Count > 0)
            {
                TextureGroups.Add(new TextureGroup(TGFaces, TGTextures));
                listBoxTextureGroups.Items.Add(TextureGroups[TextureGroups.Count - 1]);
                listBoxFaces.Items.Clear();
                listBoxTextures.Items.Clear();
                // Change list refernces to new list, rather than the old one
                TGFaces = new List<string>();
                TGTextures = new List<string>();
            }
        }

        
    }
}
