namespace OnATheme
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUnZippedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxBlocks = new System.Windows.Forms.ListBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerBlock = new System.Windows.Forms.SplitContainer();
            this.listBoxVariants = new System.Windows.Forms.ListBox();
            this.splitContainerAttribute = new System.Windows.Forms.SplitContainer();
            this.listBoxModels = new System.Windows.Forms.ListBox();
            this.groupBoxRotation = new System.Windows.Forms.GroupBox();
            this.buttonUpdateRotations = new System.Windows.Forms.Button();
            this.groupBoxRotationY = new System.Windows.Forms.GroupBox();
            this.checkBoxY270 = new System.Windows.Forms.CheckBox();
            this.checkBoxY180 = new System.Windows.Forms.CheckBox();
            this.checkBoxY90 = new System.Windows.Forms.CheckBox();
            this.checkBoxY0 = new System.Windows.Forms.CheckBox();
            this.groupBoxRotationX = new System.Windows.Forms.GroupBox();
            this.checkBoxX270 = new System.Windows.Forms.CheckBox();
            this.checkBoxX180 = new System.Windows.Forms.CheckBox();
            this.checkBoxX90 = new System.Windows.Forms.CheckBox();
            this.checkBoxX0 = new System.Windows.Forms.CheckBox();
            this.checkBoxModelJson = new System.Windows.Forms.CheckBox();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.labelModelName = new System.Windows.Forms.Label();
            this.numericUpDownModelWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBlock)).BeginInit();
            this.splitContainerBlock.Panel1.SuspendLayout();
            this.splitContainerBlock.Panel2.SuspendLayout();
            this.splitContainerBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttribute)).BeginInit();
            this.splitContainerAttribute.Panel1.SuspendLayout();
            this.splitContainerAttribute.Panel2.SuspendLayout();
            this.splitContainerAttribute.SuspendLayout();
            this.groupBoxRotation.SuspendLayout();
            this.groupBoxRotationY.SuspendLayout();
            this.groupBoxRotationX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModelWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.blocksToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(663, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUnZippedToolStripMenuItem,
            this.createZipToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createUnZippedToolStripMenuItem
            // 
            this.createUnZippedToolStripMenuItem.Name = "createUnZippedToolStripMenuItem";
            this.createUnZippedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createUnZippedToolStripMenuItem.Text = "Create UnZipped";
            this.createUnZippedToolStripMenuItem.Click += new System.EventHandler(this.createUnZippedToolStripMenuItem_Click);
            // 
            // createZipToolStripMenuItem
            // 
            this.createZipToolStripMenuItem.Enabled = false;
            this.createZipToolStripMenuItem.Name = "createZipToolStripMenuItem";
            this.createZipToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createZipToolStripMenuItem.Text = "Create Zip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // blocksToolStripMenuItem
            // 
            this.blocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBlockToolStripMenuItem,
            this.removeBlockToolStripMenuItem});
            this.blocksToolStripMenuItem.Name = "blocksToolStripMenuItem";
            this.blocksToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.blocksToolStripMenuItem.Text = "Blocks";
            // 
            // addBlockToolStripMenuItem
            // 
            this.addBlockToolStripMenuItem.Name = "addBlockToolStripMenuItem";
            this.addBlockToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addBlockToolStripMenuItem.Text = "Add Block";
            this.addBlockToolStripMenuItem.Click += new System.EventHandler(this.addBlockToolStripMenuItem_Click);
            // 
            // removeBlockToolStripMenuItem
            // 
            this.removeBlockToolStripMenuItem.Name = "removeBlockToolStripMenuItem";
            this.removeBlockToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeBlockToolStripMenuItem.Text = "Remove Block";
            this.removeBlockToolStripMenuItem.Click += new System.EventHandler(this.removeBlockToolStripMenuItem_Click);
            // 
            // listBoxBlocks
            // 
            this.listBoxBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBlocks.FormattingEnabled = true;
            this.listBoxBlocks.Location = new System.Drawing.Point(0, 0);
            this.listBoxBlocks.Name = "listBoxBlocks";
            this.listBoxBlocks.Size = new System.Drawing.Size(178, 312);
            this.listBoxBlocks.TabIndex = 1;
            this.listBoxBlocks.SelectedIndexChanged += new System.EventHandler(this.listBoxBlocks_SelectedIndexChanged);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.listBoxBlocks);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBlock);
            this.splitContainerMain.Size = new System.Drawing.Size(663, 312);
            this.splitContainerMain.SplitterDistance = 178;
            this.splitContainerMain.TabIndex = 2;
            // 
            // splitContainerBlock
            // 
            this.splitContainerBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBlock.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBlock.Name = "splitContainerBlock";
            // 
            // splitContainerBlock.Panel1
            // 
            this.splitContainerBlock.Panel1.Controls.Add(this.listBoxVariants);
            // 
            // splitContainerBlock.Panel2
            // 
            this.splitContainerBlock.Panel2.Controls.Add(this.splitContainerAttribute);
            this.splitContainerBlock.Size = new System.Drawing.Size(481, 312);
            this.splitContainerBlock.SplitterDistance = 159;
            this.splitContainerBlock.TabIndex = 1;
            // 
            // listBoxVariants
            // 
            this.listBoxVariants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxVariants.FormattingEnabled = true;
            this.listBoxVariants.Location = new System.Drawing.Point(0, 0);
            this.listBoxVariants.Name = "listBoxVariants";
            this.listBoxVariants.Size = new System.Drawing.Size(159, 312);
            this.listBoxVariants.TabIndex = 0;
            this.listBoxVariants.SelectedIndexChanged += new System.EventHandler(this.listBoxVariants_SelectedIndexChanged);
            // 
            // splitContainerAttribute
            // 
            this.splitContainerAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAttribute.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAttribute.Name = "splitContainerAttribute";
            // 
            // splitContainerAttribute.Panel1
            // 
            this.splitContainerAttribute.Panel1.Controls.Add(this.listBoxModels);
            // 
            // splitContainerAttribute.Panel2
            // 
            this.splitContainerAttribute.Panel2.Controls.Add(this.groupBoxRotation);
            this.splitContainerAttribute.Panel2.Controls.Add(this.checkBoxModelJson);
            this.splitContainerAttribute.Panel2.Controls.Add(this.textBoxModelName);
            this.splitContainerAttribute.Panel2.Controls.Add(this.labelModelName);
            this.splitContainerAttribute.Panel2.Controls.Add(this.numericUpDownModelWeight);
            this.splitContainerAttribute.Panel2.Controls.Add(this.labelWeight);
            this.splitContainerAttribute.Panel2.Enabled = false;
            this.splitContainerAttribute.Size = new System.Drawing.Size(318, 312);
            this.splitContainerAttribute.SplitterDistance = 161;
            this.splitContainerAttribute.TabIndex = 0;
            // 
            // listBoxModels
            // 
            this.listBoxModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxModels.FormattingEnabled = true;
            this.listBoxModels.Location = new System.Drawing.Point(0, 0);
            this.listBoxModels.Name = "listBoxModels";
            this.listBoxModels.Size = new System.Drawing.Size(161, 312);
            this.listBoxModels.TabIndex = 0;
            this.listBoxModels.SelectedIndexChanged += new System.EventHandler(this.listBoxModels_SelectedIndexChanged);
            // 
            // groupBoxRotation
            // 
            this.groupBoxRotation.Controls.Add(this.buttonUpdateRotations);
            this.groupBoxRotation.Controls.Add(this.groupBoxRotationY);
            this.groupBoxRotation.Controls.Add(this.groupBoxRotationX);
            this.groupBoxRotation.Location = new System.Drawing.Point(6, 109);
            this.groupBoxRotation.Name = "groupBoxRotation";
            this.groupBoxRotation.Size = new System.Drawing.Size(139, 191);
            this.groupBoxRotation.TabIndex = 18;
            this.groupBoxRotation.TabStop = false;
            this.groupBoxRotation.Text = "Rotations";
            // 
            // buttonUpdateRotations
            // 
            this.buttonUpdateRotations.Location = new System.Drawing.Point(7, 165);
            this.buttonUpdateRotations.Name = "buttonUpdateRotations";
            this.buttonUpdateRotations.Size = new System.Drawing.Size(124, 23);
            this.buttonUpdateRotations.TabIndex = 2;
            this.buttonUpdateRotations.Text = "Update Rotations";
            this.buttonUpdateRotations.UseVisualStyleBackColor = true;
            this.buttonUpdateRotations.Click += new System.EventHandler(this.buttonUpdateRotations_Click);
            // 
            // groupBoxRotationY
            // 
            this.groupBoxRotationY.Controls.Add(this.checkBoxY270);
            this.groupBoxRotationY.Controls.Add(this.checkBoxY180);
            this.groupBoxRotationY.Controls.Add(this.checkBoxY90);
            this.groupBoxRotationY.Controls.Add(this.checkBoxY0);
            this.groupBoxRotationY.Location = new System.Drawing.Point(7, 92);
            this.groupBoxRotationY.Name = "groupBoxRotationY";
            this.groupBoxRotationY.Size = new System.Drawing.Size(124, 66);
            this.groupBoxRotationY.TabIndex = 1;
            this.groupBoxRotationY.TabStop = false;
            this.groupBoxRotationY.Text = "Y";
            // 
            // checkBoxY270
            // 
            this.checkBoxY270.AutoSize = true;
            this.checkBoxY270.Location = new System.Drawing.Point(80, 44);
            this.checkBoxY270.Name = "checkBoxY270";
            this.checkBoxY270.Size = new System.Drawing.Size(44, 17);
            this.checkBoxY270.TabIndex = 3;
            this.checkBoxY270.Text = "270";
            this.checkBoxY270.UseVisualStyleBackColor = true;
            // 
            // checkBoxY180
            // 
            this.checkBoxY180.AutoSize = true;
            this.checkBoxY180.Location = new System.Drawing.Point(6, 44);
            this.checkBoxY180.Name = "checkBoxY180";
            this.checkBoxY180.Size = new System.Drawing.Size(44, 17);
            this.checkBoxY180.TabIndex = 2;
            this.checkBoxY180.Text = "180";
            this.checkBoxY180.UseVisualStyleBackColor = true;
            // 
            // checkBoxY90
            // 
            this.checkBoxY90.AutoSize = true;
            this.checkBoxY90.Location = new System.Drawing.Point(80, 20);
            this.checkBoxY90.Name = "checkBoxY90";
            this.checkBoxY90.Size = new System.Drawing.Size(38, 17);
            this.checkBoxY90.TabIndex = 1;
            this.checkBoxY90.Text = "90";
            this.checkBoxY90.UseVisualStyleBackColor = true;
            // 
            // checkBoxY0
            // 
            this.checkBoxY0.AutoSize = true;
            this.checkBoxY0.Checked = true;
            this.checkBoxY0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxY0.Location = new System.Drawing.Point(6, 19);
            this.checkBoxY0.Name = "checkBoxY0";
            this.checkBoxY0.Size = new System.Drawing.Size(32, 17);
            this.checkBoxY0.TabIndex = 0;
            this.checkBoxY0.Text = "0";
            this.checkBoxY0.UseVisualStyleBackColor = true;
            // 
            // groupBoxRotationX
            // 
            this.groupBoxRotationX.Controls.Add(this.checkBoxX270);
            this.groupBoxRotationX.Controls.Add(this.checkBoxX180);
            this.groupBoxRotationX.Controls.Add(this.checkBoxX90);
            this.groupBoxRotationX.Controls.Add(this.checkBoxX0);
            this.groupBoxRotationX.Location = new System.Drawing.Point(7, 20);
            this.groupBoxRotationX.Name = "groupBoxRotationX";
            this.groupBoxRotationX.Size = new System.Drawing.Size(124, 66);
            this.groupBoxRotationX.TabIndex = 0;
            this.groupBoxRotationX.TabStop = false;
            this.groupBoxRotationX.Text = "X";
            // 
            // checkBoxX270
            // 
            this.checkBoxX270.AutoSize = true;
            this.checkBoxX270.Location = new System.Drawing.Point(76, 44);
            this.checkBoxX270.Name = "checkBoxX270";
            this.checkBoxX270.Size = new System.Drawing.Size(44, 17);
            this.checkBoxX270.TabIndex = 3;
            this.checkBoxX270.Text = "270";
            this.checkBoxX270.UseVisualStyleBackColor = true;
            // 
            // checkBoxX180
            // 
            this.checkBoxX180.AutoSize = true;
            this.checkBoxX180.Location = new System.Drawing.Point(7, 44);
            this.checkBoxX180.Name = "checkBoxX180";
            this.checkBoxX180.Size = new System.Drawing.Size(44, 17);
            this.checkBoxX180.TabIndex = 2;
            this.checkBoxX180.Text = "180";
            this.checkBoxX180.UseVisualStyleBackColor = true;
            // 
            // checkBoxX90
            // 
            this.checkBoxX90.AutoSize = true;
            this.checkBoxX90.Location = new System.Drawing.Point(76, 20);
            this.checkBoxX90.Name = "checkBoxX90";
            this.checkBoxX90.Size = new System.Drawing.Size(38, 17);
            this.checkBoxX90.TabIndex = 1;
            this.checkBoxX90.Text = "90";
            this.checkBoxX90.UseVisualStyleBackColor = true;
            // 
            // checkBoxX0
            // 
            this.checkBoxX0.AutoSize = true;
            this.checkBoxX0.Checked = true;
            this.checkBoxX0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX0.Location = new System.Drawing.Point(7, 20);
            this.checkBoxX0.Name = "checkBoxX0";
            this.checkBoxX0.Size = new System.Drawing.Size(32, 17);
            this.checkBoxX0.TabIndex = 0;
            this.checkBoxX0.Text = "0";
            this.checkBoxX0.UseVisualStyleBackColor = true;
            // 
            // checkBoxModelJson
            // 
            this.checkBoxModelJson.AutoSize = true;
            this.checkBoxModelJson.Checked = true;
            this.checkBoxModelJson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxModelJson.Location = new System.Drawing.Point(6, 86);
            this.checkBoxModelJson.Name = "checkBoxModelJson";
            this.checkBoxModelJson.Size = new System.Drawing.Size(88, 17);
            this.checkBoxModelJson.TabIndex = 4;
            this.checkBoxModelJson.Text = "Create JSON";
            this.checkBoxModelJson.UseVisualStyleBackColor = true;
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(6, 60);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(120, 20);
            this.textBoxModelName.TabIndex = 3;
            // 
            // labelModelName
            // 
            this.labelModelName.AutoSize = true;
            this.labelModelName.Location = new System.Drawing.Point(3, 44);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(110, 13);
            this.labelModelName.TabIndex = 2;
            this.labelModelName.Text = "Override Model Name";
            // 
            // numericUpDownModelWeight
            // 
            this.numericUpDownModelWeight.Location = new System.Drawing.Point(6, 17);
            this.numericUpDownModelWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownModelWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownModelWeight.Name = "numericUpDownModelWeight";
            this.numericUpDownModelWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownModelWeight.TabIndex = 1;
            this.numericUpDownModelWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownModelWeight.ValueChanged += new System.EventHandler(this.numericUpDownModelWeight_ValueChanged);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(3, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(73, 13);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Model Weight";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 336);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "On A Theme - JSON Generator";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerBlock.Panel1.ResumeLayout(false);
            this.splitContainerBlock.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBlock)).EndInit();
            this.splitContainerBlock.ResumeLayout(false);
            this.splitContainerAttribute.Panel1.ResumeLayout(false);
            this.splitContainerAttribute.Panel2.ResumeLayout(false);
            this.splitContainerAttribute.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAttribute)).EndInit();
            this.splitContainerAttribute.ResumeLayout(false);
            this.groupBoxRotation.ResumeLayout(false);
            this.groupBoxRotationY.ResumeLayout(false);
            this.groupBoxRotationY.PerformLayout();
            this.groupBoxRotationX.ResumeLayout(false);
            this.groupBoxRotationX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModelWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createZipToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBlockToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxBlocks;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerAttribute;
        private System.Windows.Forms.ListBox listBoxModels;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownModelWeight;
        private System.Windows.Forms.ToolStripMenuItem createUnZippedToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerBlock;
        private System.Windows.Forms.ListBox listBoxVariants;
        private System.Windows.Forms.TextBox textBoxModelName;
        private System.Windows.Forms.Label labelModelName;
        private System.Windows.Forms.CheckBox checkBoxModelJson;
        private System.Windows.Forms.GroupBox groupBoxRotation;
        private System.Windows.Forms.GroupBox groupBoxRotationY;
        private System.Windows.Forms.CheckBox checkBoxY270;
        private System.Windows.Forms.CheckBox checkBoxY180;
        private System.Windows.Forms.CheckBox checkBoxY90;
        private System.Windows.Forms.CheckBox checkBoxY0;
        private System.Windows.Forms.GroupBox groupBoxRotationX;
        private System.Windows.Forms.CheckBox checkBoxX270;
        private System.Windows.Forms.CheckBox checkBoxX180;
        private System.Windows.Forms.CheckBox checkBoxX90;
        private System.Windows.Forms.CheckBox checkBoxX0;
        private System.Windows.Forms.Button buttonUpdateRotations;
    }
}

