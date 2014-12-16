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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.listBoxBlockVariants = new System.Windows.Forms.ListBox();
            this.buttonAddBlockVariant = new System.Windows.Forms.Button();
            this.labelBlockVariants = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBlockName
            // 
            this.labelBlockName.AutoSize = true;
            this.labelBlockName.Location = new System.Drawing.Point(7, 13);
            this.labelBlockName.Name = "labelBlockName";
            this.labelBlockName.Size = new System.Drawing.Size(65, 13);
            this.labelBlockName.TabIndex = 5;
            this.labelBlockName.Text = "Block Name";
            // 
            // textBoxBlockName
            // 
            this.textBoxBlockName.Location = new System.Drawing.Point(84, 10);
            this.textBoxBlockName.Name = "textBoxBlockName";
            this.textBoxBlockName.Size = new System.Drawing.Size(113, 20);
            this.textBoxBlockName.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCreate.Location = new System.Drawing.Point(10, 192);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(187, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create Block";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // listBoxBlockVariants
            // 
            this.listBoxBlockVariants.FormattingEnabled = true;
            this.listBoxBlockVariants.Location = new System.Drawing.Point(10, 49);
            this.listBoxBlockVariants.Name = "listBoxBlockVariants";
            this.listBoxBlockVariants.Size = new System.Drawing.Size(187, 108);
            this.listBoxBlockVariants.TabIndex = 4;
            // 
            // buttonAddBlockVariant
            // 
            this.buttonAddBlockVariant.Location = new System.Drawing.Point(10, 163);
            this.buttonAddBlockVariant.Name = "buttonAddBlockVariant";
            this.buttonAddBlockVariant.Size = new System.Drawing.Size(187, 23);
            this.buttonAddBlockVariant.TabIndex = 2;
            this.buttonAddBlockVariant.Text = "Add Block Variant";
            this.buttonAddBlockVariant.UseVisualStyleBackColor = true;
            this.buttonAddBlockVariant.Click += new System.EventHandler(this.buttonAddBlockVariant_Click);
            // 
            // labelBlockVariants
            // 
            this.labelBlockVariants.AutoSize = true;
            this.labelBlockVariants.Location = new System.Drawing.Point(7, 33);
            this.labelBlockVariants.Name = "labelBlockVariants";
            this.labelBlockVariants.Size = new System.Drawing.Size(75, 13);
            this.labelBlockVariants.TabIndex = 6;
            this.labelBlockVariants.Text = "Block Variants";
            // 
            // FormAddBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 225);
            this.Controls.Add(this.labelBlockVariants);
            this.Controls.Add(this.buttonAddBlockVariant);
            this.Controls.Add(this.listBoxBlockVariants);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxBlockName);
            this.Controls.Add(this.labelBlockName);
            this.Name = "FormAddBlock";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Block";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBlockName;
        private System.Windows.Forms.TextBox textBoxBlockName;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListBox listBoxBlockVariants;
        private System.Windows.Forms.Button buttonAddBlockVariant;
        private System.Windows.Forms.Label labelBlockVariants;
    }
}