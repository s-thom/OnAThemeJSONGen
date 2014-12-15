namespace OnATheme
{
    partial class FormAddBlock
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
            this.labelBlockName = new System.Windows.Forms.Label();
            this.textBoxBlockName = new System.Windows.Forms.TextBox();
            this.labelTextureName = new System.Windows.Forms.Label();
            this.textBoxTextureName = new System.Windows.Forms.TextBox();
            this.labelVariants = new System.Windows.Forms.Label();
            this.numericUpDownVariants = new System.Windows.Forms.NumericUpDown();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariants)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBlockName
            // 
            this.labelBlockName.AutoSize = true;
            this.labelBlockName.Location = new System.Drawing.Point(13, 13);
            this.labelBlockName.Name = "labelBlockName";
            this.labelBlockName.Size = new System.Drawing.Size(65, 13);
            this.labelBlockName.TabIndex = 0;
            this.labelBlockName.Text = "Block Name";
            // 
            // textBoxBlockName
            // 
            this.textBoxBlockName.Location = new System.Drawing.Point(96, 10);
            this.textBoxBlockName.Name = "textBoxBlockName";
            this.textBoxBlockName.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlockName.TabIndex = 1;
            // 
            // labelTextureName
            // 
            this.labelTextureName.AutoSize = true;
            this.labelTextureName.Location = new System.Drawing.Point(13, 39);
            this.labelTextureName.Name = "labelTextureName";
            this.labelTextureName.Size = new System.Drawing.Size(74, 13);
            this.labelTextureName.TabIndex = 2;
            this.labelTextureName.Text = "Texture Name";
            // 
            // textBoxTextureName
            // 
            this.textBoxTextureName.Location = new System.Drawing.Point(96, 36);
            this.textBoxTextureName.Name = "textBoxTextureName";
            this.textBoxTextureName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTextureName.TabIndex = 3;
            // 
            // labelVariants
            // 
            this.labelVariants.AutoSize = true;
            this.labelVariants.Location = new System.Drawing.Point(13, 65);
            this.labelVariants.Name = "labelVariants";
            this.labelVariants.Size = new System.Drawing.Size(45, 13);
            this.labelVariants.TabIndex = 4;
            this.labelVariants.Text = "Variants";
            // 
            // numericUpDownVariants
            // 
            this.numericUpDownVariants.Location = new System.Drawing.Point(96, 63);
            this.numericUpDownVariants.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownVariants.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVariants.Name = "numericUpDownVariants";
            this.numericUpDownVariants.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownVariants.TabIndex = 5;
            this.numericUpDownVariants.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 119);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(183, 23);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Don\'t Create Models",
            "Full Block",
            "Cross",
            "Cross Tint",
            "Double Cross",
            "Double Cross Tint"});
            this.comboBoxType.Location = new System.Drawing.Point(96, 90);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxType.TabIndex = 7;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(13, 93);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(63, 13);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Model Type";
            // 
            // FormAddBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 154);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.numericUpDownVariants);
            this.Controls.Add(this.labelVariants);
            this.Controls.Add(this.textBoxTextureName);
            this.Controls.Add(this.labelTextureName);
            this.Controls.Add(this.textBoxBlockName);
            this.Controls.Add(this.labelBlockName);
            this.Name = "FormAddBlock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Block";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVariants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBlockName;
        private System.Windows.Forms.TextBox textBoxBlockName;
        private System.Windows.Forms.Label labelTextureName;
        private System.Windows.Forms.TextBox textBoxTextureName;
        private System.Windows.Forms.Label labelVariants;
        private System.Windows.Forms.NumericUpDown numericUpDownVariants;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
    }
}