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
            this.splitContainerBlockstates = new System.Windows.Forms.SplitContainer();
            this.listBoxModels = new System.Windows.Forms.ListBox();
            this.numericUpDownModelWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBlockstates)).BeginInit();
            this.splitContainerBlockstates.Panel1.SuspendLayout();
            this.splitContainerBlockstates.Panel2.SuspendLayout();
            this.splitContainerBlockstates.SuspendLayout();
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
            this.menuStripMain.Size = new System.Drawing.Size(473, 24);
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
            this.listBoxBlocks.Size = new System.Drawing.Size(157, 288);
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
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerBlockstates);
            this.splitContainerMain.Size = new System.Drawing.Size(473, 288);
            this.splitContainerMain.SplitterDistance = 157;
            this.splitContainerMain.TabIndex = 2;
            // 
            // splitContainerBlockstates
            // 
            this.splitContainerBlockstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBlockstates.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBlockstates.Name = "splitContainerBlockstates";
            // 
            // splitContainerBlockstates.Panel1
            // 
            this.splitContainerBlockstates.Panel1.Controls.Add(this.listBoxModels);
            // 
            // splitContainerBlockstates.Panel2
            // 
            this.splitContainerBlockstates.Panel2.Controls.Add(this.numericUpDownModelWeight);
            this.splitContainerBlockstates.Panel2.Controls.Add(this.labelWeight);
            this.splitContainerBlockstates.Size = new System.Drawing.Size(312, 288);
            this.splitContainerBlockstates.SplitterDistance = 169;
            this.splitContainerBlockstates.TabIndex = 0;
            // 
            // listBoxModels
            // 
            this.listBoxModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxModels.FormattingEnabled = true;
            this.listBoxModels.Location = new System.Drawing.Point(0, 0);
            this.listBoxModels.Name = "listBoxModels";
            this.listBoxModels.Size = new System.Drawing.Size(169, 288);
            this.listBoxModels.TabIndex = 0;
            this.listBoxModels.SelectedIndexChanged += new System.EventHandler(this.listBoxModels_SelectedIndexChanged);
            // 
            // numericUpDownModelWeight
            // 
            this.numericUpDownModelWeight.Enabled = false;
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
            this.labelWeight.Enabled = false;
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
            this.ClientSize = new System.Drawing.Size(473, 312);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "On A Theme - JSON Generator";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerBlockstates.Panel1.ResumeLayout(false);
            this.splitContainerBlockstates.Panel2.ResumeLayout(false);
            this.splitContainerBlockstates.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBlockstates)).EndInit();
            this.splitContainerBlockstates.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainerBlockstates;
        private System.Windows.Forms.ListBox listBoxModels;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownModelWeight;
        private System.Windows.Forms.ToolStripMenuItem createUnZippedToolStripMenuItem;
    }
}

