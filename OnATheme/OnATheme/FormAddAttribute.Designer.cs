namespace OnATheme
{
    partial class FormAddAttribute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTextures = new System.Windows.Forms.Label();
            this.listBoxTextures = new System.Windows.Forms.ListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelRef = new System.Windows.Forms.Label();
            this.labelTexture = new System.Windows.Forms.Label();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.textBoxTexture = new System.Windows.Forms.TextBox();
            this.labelParentModel = new System.Windows.Forms.Label();
            this.textBoxParentModel = new System.Windows.Forms.TextBox();
            this.numericUpDownVariants = new System.Windows.Forms.NumericUpDown();
            this.labelNumVariants = new System.Windows.Forms.Label();
            this.buttonAddTexture = new System.Windows.Forms.Button();
            this.groupBoxAddTexture = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariants)).BeginInit();
            this.groupBoxAddTexture.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name (i.e. \"half=upper\")";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(10, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(162, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelTextures
            // 
            this.labelTextures.AutoSize = true;
            this.labelTextures.Location = new System.Drawing.Point(7, 123);
            this.labelTextures.Name = "labelTextures";
            this.labelTextures.Size = new System.Drawing.Size(48, 13);
            this.labelTextures.TabIndex = 2;
            this.labelTextures.Text = "Textures";
            // 
            // listBoxTextures
            // 
            this.listBoxTextures.FormattingEnabled = true;
            this.listBoxTextures.Location = new System.Drawing.Point(10, 139);
            this.listBoxTextures.Name = "listBoxTextures";
            this.listBoxTextures.Size = new System.Drawing.Size(162, 121);
            this.listBoxTextures.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCreate.Location = new System.Drawing.Point(10, 373);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(162, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.Location = new System.Drawing.Point(6, 23);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(57, 13);
            this.labelRef.TabIndex = 5;
            this.labelRef.Text = "Reference";
            // 
            // labelTexture
            // 
            this.labelTexture.AutoSize = true;
            this.labelTexture.Location = new System.Drawing.Point(6, 49);
            this.labelTexture.Name = "labelTexture";
            this.labelTexture.Size = new System.Drawing.Size(43, 13);
            this.labelTexture.TabIndex = 6;
            this.labelTexture.Text = "Texture";
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(69, 20);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(87, 20);
            this.textBoxRef.TabIndex = 7;
            // 
            // textBoxTexture
            // 
            this.textBoxTexture.Location = new System.Drawing.Point(69, 46);
            this.textBoxTexture.Name = "textBoxTexture";
            this.textBoxTexture.Size = new System.Drawing.Size(87, 20);
            this.textBoxTexture.TabIndex = 8;
            // 
            // labelParentModel
            // 
            this.labelParentModel.AutoSize = true;
            this.labelParentModel.Location = new System.Drawing.Point(7, 58);
            this.labelParentModel.Name = "labelParentModel";
            this.labelParentModel.Size = new System.Drawing.Size(70, 13);
            this.labelParentModel.TabIndex = 9;
            this.labelParentModel.Text = "Parent Model";
            // 
            // textBoxParentModel
            // 
            this.textBoxParentModel.Location = new System.Drawing.Point(10, 74);
            this.textBoxParentModel.Name = "textBoxParentModel";
            this.textBoxParentModel.Size = new System.Drawing.Size(162, 20);
            this.textBoxParentModel.TabIndex = 10;
            // 
            // numericUpDownVariants
            // 
            this.numericUpDownVariants.Location = new System.Drawing.Point(58, 100);
            this.numericUpDownVariants.Name = "numericUpDownVariants";
            this.numericUpDownVariants.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownVariants.TabIndex = 11;
            // 
            // labelNumVariants
            // 
            this.labelNumVariants.AutoSize = true;
            this.labelNumVariants.Location = new System.Drawing.Point(7, 102);
            this.labelNumVariants.Name = "labelNumVariants";
            this.labelNumVariants.Size = new System.Drawing.Size(45, 13);
            this.labelNumVariants.TabIndex = 12;
            this.labelNumVariants.Text = "Variants";
            // 
            // buttonAddTexture
            // 
            this.buttonAddTexture.Location = new System.Drawing.Point(6, 72);
            this.buttonAddTexture.Name = "buttonAddTexture";
            this.buttonAddTexture.Size = new System.Drawing.Size(150, 23);
            this.buttonAddTexture.TabIndex = 13;
            this.buttonAddTexture.Text = "Add Texture";
            this.buttonAddTexture.UseVisualStyleBackColor = true;
            this.buttonAddTexture.Click += new System.EventHandler(this.buttonAddTexture_Click);
            // 
            // groupBoxAddTexture
            // 
            this.groupBoxAddTexture.Controls.Add(this.buttonAddTexture);
            this.groupBoxAddTexture.Controls.Add(this.textBoxTexture);
            this.groupBoxAddTexture.Controls.Add(this.labelTexture);
            this.groupBoxAddTexture.Controls.Add(this.textBoxRef);
            this.groupBoxAddTexture.Controls.Add(this.labelRef);
            this.groupBoxAddTexture.Location = new System.Drawing.Point(10, 266);
            this.groupBoxAddTexture.Name = "groupBoxAddTexture";
            this.groupBoxAddTexture.Size = new System.Drawing.Size(162, 101);
            this.groupBoxAddTexture.TabIndex = 14;
            this.groupBoxAddTexture.TabStop = false;
            this.groupBoxAddTexture.Text = "Add Texture";
            // 
            // FormAddAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 406);
            this.Controls.Add(this.groupBoxAddTexture);
            this.Controls.Add(this.labelNumVariants);
            this.Controls.Add(this.numericUpDownVariants);
            this.Controls.Add(this.textBoxParentModel);
            this.Controls.Add(this.labelParentModel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.listBoxTextures);
            this.Controls.Add(this.labelTextures);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormAddAttribute";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Attribute";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariants)).EndInit();
            this.groupBoxAddTexture.ResumeLayout(false);
            this.groupBoxAddTexture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTextures;
        private System.Windows.Forms.ListBox listBoxTextures;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.Label labelTexture;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.TextBox textBoxTexture;
        private System.Windows.Forms.Label labelParentModel;
        private System.Windows.Forms.TextBox textBoxParentModel;
        private System.Windows.Forms.NumericUpDown numericUpDownVariants;
        private System.Windows.Forms.Label labelNumVariants;
        private System.Windows.Forms.Button buttonAddTexture;
        private System.Windows.Forms.GroupBox groupBoxAddTexture;
    }
}