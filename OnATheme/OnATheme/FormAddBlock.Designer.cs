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
            this.listBoxAttributes = new System.Windows.Forms.ListBox();
            this.buttonAddAttribute = new System.Windows.Forms.Button();
            this.labelAttributes = new System.Windows.Forms.Label();
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
            // listBoxAttributes
            // 
            this.listBoxAttributes.FormattingEnabled = true;
            this.listBoxAttributes.Location = new System.Drawing.Point(10, 49);
            this.listBoxAttributes.Name = "listBoxAttributes";
            this.listBoxAttributes.Size = new System.Drawing.Size(187, 108);
            this.listBoxAttributes.TabIndex = 4;
            // 
            // buttonAddAttribute
            // 
            this.buttonAddAttribute.Location = new System.Drawing.Point(10, 163);
            this.buttonAddAttribute.Name = "buttonAddAttribute";
            this.buttonAddAttribute.Size = new System.Drawing.Size(187, 23);
            this.buttonAddAttribute.TabIndex = 2;
            this.buttonAddAttribute.Text = "Add";
            this.buttonAddAttribute.UseVisualStyleBackColor = true;
            this.buttonAddAttribute.Click += new System.EventHandler(this.buttonAddAttribute_Click);
            // 
            // labelAttributes
            // 
            this.labelAttributes.AutoSize = true;
            this.labelAttributes.Location = new System.Drawing.Point(7, 33);
            this.labelAttributes.Name = "labelAttributes";
            this.labelAttributes.Size = new System.Drawing.Size(51, 13);
            this.labelAttributes.TabIndex = 6;
            this.labelAttributes.Text = "Attributes";
            // 
            // FormAddBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 225);
            this.Controls.Add(this.labelAttributes);
            this.Controls.Add(this.buttonAddAttribute);
            this.Controls.Add(this.listBoxAttributes);
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
        private System.Windows.Forms.ListBox listBoxAttributes;
        private System.Windows.Forms.Button buttonAddAttribute;
        private System.Windows.Forms.Label labelAttributes;
    }
}