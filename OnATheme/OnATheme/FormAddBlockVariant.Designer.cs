namespace OnATheme
{
    partial class FormAddBlockVariant
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
            this.listBoxTextures = new System.Windows.Forms.ListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelRef = new System.Windows.Forms.Label();
            this.labelTexture = new System.Windows.Forms.Label();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.textBoxTexture = new System.Windows.Forms.TextBox();
            this.labelParentModel = new System.Windows.Forms.Label();
            this.textBoxParentModel = new System.Windows.Forms.TextBox();
            this.buttonAddTexture = new System.Windows.Forms.Button();
            this.labelOverwrite = new System.Windows.Forms.Label();
            this.textBoxOverwrite = new System.Windows.Forms.TextBox();
            this.groupBoxTextureGroups = new System.Windows.Forms.GroupBox();
            this.listBoxTextureGroups = new System.Windows.Forms.ListBox();
            this.groupBoxNewTextureGroup = new System.Windows.Forms.GroupBox();
            this.buttonAddTextureGroup = new System.Windows.Forms.Button();
            this.buttonAddRef = new System.Windows.Forms.Button();
            this.listBoxFaces = new System.Windows.Forms.ListBox();
            this.groupBoxRotation = new System.Windows.Forms.GroupBox();
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
            this.groupBoxModel = new System.Windows.Forms.GroupBox();
            this.groupBoxTexturesSequential = new System.Windows.Forms.GroupBox();
            this.labelSeqNumVariants = new System.Windows.Forms.Label();
            this.numericUpDownNumVariants = new System.Windows.Forms.NumericUpDown();
            this.groupBoxSequentialTexVar = new System.Windows.Forms.GroupBox();
            this.buttonSeqVarAdd = new System.Windows.Forms.Button();
            this.textBoxSeqVarReference = new System.Windows.Forms.TextBox();
            this.labelSeqVarReference = new System.Windows.Forms.Label();
            this.textBoxSeqVarTexture = new System.Windows.Forms.TextBox();
            this.labelSeqVarTexture = new System.Windows.Forms.Label();
            this.listBoxSeqVar = new System.Windows.Forms.ListBox();
            this.groupBoxSequentialTexConst = new System.Windows.Forms.GroupBox();
            this.buttonSeqConstAdd = new System.Windows.Forms.Button();
            this.textBoxSeqConstReference = new System.Windows.Forms.TextBox();
            this.labelSeqConstReference = new System.Windows.Forms.Label();
            this.textBoxSeqConstTexture = new System.Windows.Forms.TextBox();
            this.labelSeqConstTexture = new System.Windows.Forms.Label();
            this.listBoxSeqConst = new System.Windows.Forms.ListBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonTypeSequential = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeExponential = new System.Windows.Forms.RadioButton();
            this.linkLabelInstructions = new System.Windows.Forms.LinkLabel();
            this.groupBoxTextureGroups.SuspendLayout();
            this.groupBoxNewTextureGroup.SuspendLayout();
            this.groupBoxRotation.SuspendLayout();
            this.groupBoxRotationY.SuspendLayout();
            this.groupBoxRotationX.SuspendLayout();
            this.groupBoxModel.SuspendLayout();
            this.groupBoxTexturesSequential.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumVariants)).BeginInit();
            this.groupBoxSequentialTexVar.SuspendLayout();
            this.groupBoxSequentialTexConst.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(125, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name (e.g. \"half=upper\")";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(10, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(162, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // listBoxTextures
            // 
            this.listBoxTextures.FormattingEnabled = true;
            this.listBoxTextures.Location = new System.Drawing.Point(6, 19);
            this.listBoxTextures.Name = "listBoxTextures";
            this.listBoxTextures.Size = new System.Drawing.Size(153, 69);
            this.listBoxTextures.TabIndex = 11;
            // 
            // buttonCreate
            // 
            this.buttonCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(10, 478);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(714, 26);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Create Block Variant";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.Location = new System.Drawing.Point(171, 97);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(57, 13);
            this.labelRef.TabIndex = 5;
            this.labelRef.Text = "Reference";
            // 
            // labelTexture
            // 
            this.labelTexture.AutoSize = true;
            this.labelTexture.Location = new System.Drawing.Point(5, 97);
            this.labelTexture.Name = "labelTexture";
            this.labelTexture.Size = new System.Drawing.Size(43, 13);
            this.labelTexture.TabIndex = 6;
            this.labelTexture.Text = "Texture";
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(234, 94);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(93, 20);
            this.textBoxRef.TabIndex = 7;
            // 
            // textBoxTexture
            // 
            this.textBoxTexture.Location = new System.Drawing.Point(54, 94);
            this.textBoxTexture.Name = "textBoxTexture";
            this.textBoxTexture.Size = new System.Drawing.Size(105, 20);
            this.textBoxTexture.TabIndex = 8;
            // 
            // labelParentModel
            // 
            this.labelParentModel.AutoSize = true;
            this.labelParentModel.Location = new System.Drawing.Point(3, 16);
            this.labelParentModel.Name = "labelParentModel";
            this.labelParentModel.Size = new System.Drawing.Size(70, 13);
            this.labelParentModel.TabIndex = 9;
            this.labelParentModel.Text = "Parent Model";
            // 
            // textBoxParentModel
            // 
            this.textBoxParentModel.Location = new System.Drawing.Point(6, 32);
            this.textBoxParentModel.Name = "textBoxParentModel";
            this.textBoxParentModel.Size = new System.Drawing.Size(167, 20);
            this.textBoxParentModel.TabIndex = 2;
            // 
            // buttonAddTexture
            // 
            this.buttonAddTexture.Location = new System.Drawing.Point(6, 120);
            this.buttonAddTexture.Name = "buttonAddTexture";
            this.buttonAddTexture.Size = new System.Drawing.Size(153, 23);
            this.buttonAddTexture.TabIndex = 9;
            this.buttonAddTexture.Text = "Add Texture";
            this.buttonAddTexture.UseVisualStyleBackColor = true;
            this.buttonAddTexture.Click += new System.EventHandler(this.buttonAddTexture_Click);
            // 
            // labelOverwrite
            // 
            this.labelOverwrite.AutoSize = true;
            this.labelOverwrite.Location = new System.Drawing.Point(185, 16);
            this.labelOverwrite.Name = "labelOverwrite";
            this.labelOverwrite.Size = new System.Drawing.Size(120, 13);
            this.labelOverwrite.TabIndex = 15;
            this.labelOverwrite.Text = "Overwrite Model Names";
            // 
            // textBoxOverwrite
            // 
            this.textBoxOverwrite.Location = new System.Drawing.Point(188, 32);
            this.textBoxOverwrite.Name = "textBoxOverwrite";
            this.textBoxOverwrite.Size = new System.Drawing.Size(165, 20);
            this.textBoxOverwrite.TabIndex = 4;
            // 
            // groupBoxTextureGroups
            // 
            this.groupBoxTextureGroups.Controls.Add(this.listBoxTextureGroups);
            this.groupBoxTextureGroups.Controls.Add(this.groupBoxNewTextureGroup);
            this.groupBoxTextureGroups.Enabled = false;
            this.groupBoxTextureGroups.Location = new System.Drawing.Point(6, 106);
            this.groupBoxTextureGroups.Name = "groupBoxTextureGroups";
            this.groupBoxTextureGroups.Size = new System.Drawing.Size(347, 305);
            this.groupBoxTextureGroups.TabIndex = 5;
            this.groupBoxTextureGroups.TabStop = false;
            this.groupBoxTextureGroups.Text = "Exponential Textures";
            // 
            // listBoxTextureGroups
            // 
            this.listBoxTextureGroups.FormattingEnabled = true;
            this.listBoxTextureGroups.Location = new System.Drawing.Point(6, 204);
            this.listBoxTextureGroups.Name = "listBoxTextureGroups";
            this.listBoxTextureGroups.Size = new System.Drawing.Size(335, 95);
            this.listBoxTextureGroups.TabIndex = 15;
            // 
            // groupBoxNewTextureGroup
            // 
            this.groupBoxNewTextureGroup.Controls.Add(this.buttonAddTextureGroup);
            this.groupBoxNewTextureGroup.Controls.Add(this.listBoxTextures);
            this.groupBoxNewTextureGroup.Controls.Add(this.buttonAddRef);
            this.groupBoxNewTextureGroup.Controls.Add(this.listBoxFaces);
            this.groupBoxNewTextureGroup.Controls.Add(this.buttonAddTexture);
            this.groupBoxNewTextureGroup.Controls.Add(this.labelRef);
            this.groupBoxNewTextureGroup.Controls.Add(this.labelTexture);
            this.groupBoxNewTextureGroup.Controls.Add(this.textBoxRef);
            this.groupBoxNewTextureGroup.Controls.Add(this.textBoxTexture);
            this.groupBoxNewTextureGroup.Location = new System.Drawing.Point(6, 19);
            this.groupBoxNewTextureGroup.Name = "groupBoxNewTextureGroup";
            this.groupBoxNewTextureGroup.Size = new System.Drawing.Size(335, 179);
            this.groupBoxNewTextureGroup.TabIndex = 14;
            this.groupBoxNewTextureGroup.TabStop = false;
            this.groupBoxNewTextureGroup.Text = "New Texture Group";
            // 
            // buttonAddTextureGroup
            // 
            this.buttonAddTextureGroup.Location = new System.Drawing.Point(6, 149);
            this.buttonAddTextureGroup.Name = "buttonAddTextureGroup";
            this.buttonAddTextureGroup.Size = new System.Drawing.Size(321, 23);
            this.buttonAddTextureGroup.TabIndex = 14;
            this.buttonAddTextureGroup.Text = "Add Texture Group";
            this.buttonAddTextureGroup.UseVisualStyleBackColor = true;
            this.buttonAddTextureGroup.Click += new System.EventHandler(this.buttonAddTextureGroup_Click);
            // 
            // buttonAddRef
            // 
            this.buttonAddRef.Location = new System.Drawing.Point(174, 120);
            this.buttonAddRef.Name = "buttonAddRef";
            this.buttonAddRef.Size = new System.Drawing.Size(153, 23);
            this.buttonAddRef.TabIndex = 13;
            this.buttonAddRef.Text = "Add Reference";
            this.buttonAddRef.UseVisualStyleBackColor = true;
            this.buttonAddRef.Click += new System.EventHandler(this.buttonAddRef_Click);
            // 
            // listBoxFaces
            // 
            this.listBoxFaces.FormattingEnabled = true;
            this.listBoxFaces.Location = new System.Drawing.Point(174, 19);
            this.listBoxFaces.Name = "listBoxFaces";
            this.listBoxFaces.Size = new System.Drawing.Size(153, 69);
            this.listBoxFaces.TabIndex = 12;
            // 
            // groupBoxRotation
            // 
            this.groupBoxRotation.Controls.Add(this.groupBoxRotationY);
            this.groupBoxRotation.Controls.Add(this.groupBoxRotationX);
            this.groupBoxRotation.Location = new System.Drawing.Point(359, 19);
            this.groupBoxRotation.Name = "groupBoxRotation";
            this.groupBoxRotation.Size = new System.Drawing.Size(347, 91);
            this.groupBoxRotation.TabIndex = 17;
            this.groupBoxRotation.TabStop = false;
            this.groupBoxRotation.Text = "Rotations";
            // 
            // groupBoxRotationY
            // 
            this.groupBoxRotationY.Controls.Add(this.checkBoxY270);
            this.groupBoxRotationY.Controls.Add(this.checkBoxY180);
            this.groupBoxRotationY.Controls.Add(this.checkBoxY90);
            this.groupBoxRotationY.Controls.Add(this.checkBoxY0);
            this.groupBoxRotationY.Location = new System.Drawing.Point(182, 20);
            this.groupBoxRotationY.Name = "groupBoxRotationY";
            this.groupBoxRotationY.Size = new System.Drawing.Size(159, 66);
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
            this.groupBoxRotationX.Location = new System.Drawing.Point(6, 20);
            this.groupBoxRotationX.Name = "groupBoxRotationX";
            this.groupBoxRotationX.Size = new System.Drawing.Size(160, 66);
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
            // groupBoxModel
            // 
            this.groupBoxModel.Controls.Add(this.groupBoxTexturesSequential);
            this.groupBoxModel.Controls.Add(this.groupBoxType);
            this.groupBoxModel.Controls.Add(this.groupBoxRotation);
            this.groupBoxModel.Controls.Add(this.groupBoxTextureGroups);
            this.groupBoxModel.Controls.Add(this.labelOverwrite);
            this.groupBoxModel.Controls.Add(this.textBoxOverwrite);
            this.groupBoxModel.Controls.Add(this.textBoxParentModel);
            this.groupBoxModel.Controls.Add(this.labelParentModel);
            this.groupBoxModel.Location = new System.Drawing.Point(10, 55);
            this.groupBoxModel.Name = "groupBoxModel";
            this.groupBoxModel.Size = new System.Drawing.Size(714, 417);
            this.groupBoxModel.TabIndex = 18;
            this.groupBoxModel.TabStop = false;
            this.groupBoxModel.Text = "Model";
            // 
            // groupBoxTexturesSequential
            // 
            this.groupBoxTexturesSequential.Controls.Add(this.labelSeqNumVariants);
            this.groupBoxTexturesSequential.Controls.Add(this.numericUpDownNumVariants);
            this.groupBoxTexturesSequential.Controls.Add(this.groupBoxSequentialTexVar);
            this.groupBoxTexturesSequential.Controls.Add(this.groupBoxSequentialTexConst);
            this.groupBoxTexturesSequential.Enabled = false;
            this.groupBoxTexturesSequential.Location = new System.Drawing.Point(359, 116);
            this.groupBoxTexturesSequential.Name = "groupBoxTexturesSequential";
            this.groupBoxTexturesSequential.Size = new System.Drawing.Size(347, 272);
            this.groupBoxTexturesSequential.TabIndex = 19;
            this.groupBoxTexturesSequential.TabStop = false;
            this.groupBoxTexturesSequential.Text = "Sequential Textures";
            // 
            // labelSeqNumVariants
            // 
            this.labelSeqNumVariants.AutoSize = true;
            this.labelSeqNumVariants.Location = new System.Drawing.Point(6, 21);
            this.labelSeqNumVariants.Name = "labelSeqNumVariants";
            this.labelSeqNumVariants.Size = new System.Drawing.Size(105, 13);
            this.labelSeqNumVariants.TabIndex = 8;
            this.labelSeqNumVariants.Text = "Number of Variations";
            // 
            // numericUpDownNumVariants
            // 
            this.numericUpDownNumVariants.Location = new System.Drawing.Point(117, 19);
            this.numericUpDownNumVariants.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownNumVariants.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumVariants.Name = "numericUpDownNumVariants";
            this.numericUpDownNumVariants.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumVariants.TabIndex = 7;
            this.numericUpDownNumVariants.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxSequentialTexVar
            // 
            this.groupBoxSequentialTexVar.Controls.Add(this.buttonSeqVarAdd);
            this.groupBoxSequentialTexVar.Controls.Add(this.textBoxSeqVarReference);
            this.groupBoxSequentialTexVar.Controls.Add(this.labelSeqVarReference);
            this.groupBoxSequentialTexVar.Controls.Add(this.textBoxSeqVarTexture);
            this.groupBoxSequentialTexVar.Controls.Add(this.labelSeqVarTexture);
            this.groupBoxSequentialTexVar.Controls.Add(this.listBoxSeqVar);
            this.groupBoxSequentialTexVar.Location = new System.Drawing.Point(6, 158);
            this.groupBoxSequentialTexVar.Name = "groupBoxSequentialTexVar";
            this.groupBoxSequentialTexVar.Size = new System.Drawing.Size(331, 107);
            this.groupBoxSequentialTexVar.TabIndex = 6;
            this.groupBoxSequentialTexVar.TabStop = false;
            this.groupBoxSequentialTexVar.Text = "Variable Textures";
            // 
            // buttonSeqVarAdd
            // 
            this.buttonSeqVarAdd.Location = new System.Drawing.Point(163, 78);
            this.buttonSeqVarAdd.Name = "buttonSeqVarAdd";
            this.buttonSeqVarAdd.Size = new System.Drawing.Size(162, 23);
            this.buttonSeqVarAdd.TabIndex = 5;
            this.buttonSeqVarAdd.Text = "Add";
            this.buttonSeqVarAdd.UseVisualStyleBackColor = true;
            this.buttonSeqVarAdd.Click += new System.EventHandler(this.buttonSeqVarAdd_Click);
            // 
            // textBoxSeqVarReference
            // 
            this.textBoxSeqVarReference.Location = new System.Drawing.Point(225, 52);
            this.textBoxSeqVarReference.Name = "textBoxSeqVarReference";
            this.textBoxSeqVarReference.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeqVarReference.TabIndex = 4;
            // 
            // labelSeqVarReference
            // 
            this.labelSeqVarReference.AutoSize = true;
            this.labelSeqVarReference.Location = new System.Drawing.Point(163, 55);
            this.labelSeqVarReference.Name = "labelSeqVarReference";
            this.labelSeqVarReference.Size = new System.Drawing.Size(57, 13);
            this.labelSeqVarReference.TabIndex = 3;
            this.labelSeqVarReference.Text = "Reference";
            // 
            // textBoxSeqVarTexture
            // 
            this.textBoxSeqVarTexture.Location = new System.Drawing.Point(225, 19);
            this.textBoxSeqVarTexture.Name = "textBoxSeqVarTexture";
            this.textBoxSeqVarTexture.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeqVarTexture.TabIndex = 2;
            // 
            // labelSeqVarTexture
            // 
            this.labelSeqVarTexture.AutoSize = true;
            this.labelSeqVarTexture.Location = new System.Drawing.Point(163, 22);
            this.labelSeqVarTexture.Name = "labelSeqVarTexture";
            this.labelSeqVarTexture.Size = new System.Drawing.Size(43, 13);
            this.labelSeqVarTexture.TabIndex = 1;
            this.labelSeqVarTexture.Text = "Texture";
            // 
            // listBoxSeqVar
            // 
            this.listBoxSeqVar.FormattingEnabled = true;
            this.listBoxSeqVar.Location = new System.Drawing.Point(7, 20);
            this.listBoxSeqVar.Name = "listBoxSeqVar";
            this.listBoxSeqVar.Size = new System.Drawing.Size(150, 82);
            this.listBoxSeqVar.TabIndex = 0;
            // 
            // groupBoxSequentialTexConst
            // 
            this.groupBoxSequentialTexConst.Controls.Add(this.buttonSeqConstAdd);
            this.groupBoxSequentialTexConst.Controls.Add(this.textBoxSeqConstReference);
            this.groupBoxSequentialTexConst.Controls.Add(this.labelSeqConstReference);
            this.groupBoxSequentialTexConst.Controls.Add(this.textBoxSeqConstTexture);
            this.groupBoxSequentialTexConst.Controls.Add(this.labelSeqConstTexture);
            this.groupBoxSequentialTexConst.Controls.Add(this.listBoxSeqConst);
            this.groupBoxSequentialTexConst.Location = new System.Drawing.Point(6, 45);
            this.groupBoxSequentialTexConst.Name = "groupBoxSequentialTexConst";
            this.groupBoxSequentialTexConst.Size = new System.Drawing.Size(331, 107);
            this.groupBoxSequentialTexConst.TabIndex = 0;
            this.groupBoxSequentialTexConst.TabStop = false;
            this.groupBoxSequentialTexConst.Text = "Constant Textures";
            // 
            // buttonSeqConstAdd
            // 
            this.buttonSeqConstAdd.Location = new System.Drawing.Point(163, 78);
            this.buttonSeqConstAdd.Name = "buttonSeqConstAdd";
            this.buttonSeqConstAdd.Size = new System.Drawing.Size(162, 23);
            this.buttonSeqConstAdd.TabIndex = 5;
            this.buttonSeqConstAdd.Text = "Add";
            this.buttonSeqConstAdd.UseVisualStyleBackColor = true;
            this.buttonSeqConstAdd.Click += new System.EventHandler(this.buttonSeqConstAdd_Click);
            // 
            // textBoxSeqConstReference
            // 
            this.textBoxSeqConstReference.Location = new System.Drawing.Point(225, 52);
            this.textBoxSeqConstReference.Name = "textBoxSeqConstReference";
            this.textBoxSeqConstReference.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeqConstReference.TabIndex = 4;
            // 
            // labelSeqConstReference
            // 
            this.labelSeqConstReference.AutoSize = true;
            this.labelSeqConstReference.Location = new System.Drawing.Point(163, 55);
            this.labelSeqConstReference.Name = "labelSeqConstReference";
            this.labelSeqConstReference.Size = new System.Drawing.Size(57, 13);
            this.labelSeqConstReference.TabIndex = 3;
            this.labelSeqConstReference.Text = "Reference";
            // 
            // textBoxSeqConstTexture
            // 
            this.textBoxSeqConstTexture.Location = new System.Drawing.Point(225, 19);
            this.textBoxSeqConstTexture.Name = "textBoxSeqConstTexture";
            this.textBoxSeqConstTexture.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeqConstTexture.TabIndex = 2;
            // 
            // labelSeqConstTexture
            // 
            this.labelSeqConstTexture.AutoSize = true;
            this.labelSeqConstTexture.Location = new System.Drawing.Point(163, 22);
            this.labelSeqConstTexture.Name = "labelSeqConstTexture";
            this.labelSeqConstTexture.Size = new System.Drawing.Size(43, 13);
            this.labelSeqConstTexture.TabIndex = 1;
            this.labelSeqConstTexture.Text = "Texture";
            // 
            // listBoxSeqConst
            // 
            this.listBoxSeqConst.FormattingEnabled = true;
            this.listBoxSeqConst.Location = new System.Drawing.Point(7, 20);
            this.listBoxSeqConst.Name = "listBoxSeqConst";
            this.listBoxSeqConst.Size = new System.Drawing.Size(150, 82);
            this.listBoxSeqConst.TabIndex = 0;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonTypeSequential);
            this.groupBoxType.Controls.Add(this.radioButtonTypeExponential);
            this.groupBoxType.Location = new System.Drawing.Point(9, 58);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(169, 42);
            this.groupBoxType.TabIndex = 18;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Model Type";
            // 
            // radioButtonTypeSequential
            // 
            this.radioButtonTypeSequential.AutoSize = true;
            this.radioButtonTypeSequential.Location = new System.Drawing.Point(6, 19);
            this.radioButtonTypeSequential.Name = "radioButtonTypeSequential";
            this.radioButtonTypeSequential.Size = new System.Drawing.Size(75, 17);
            this.radioButtonTypeSequential.TabIndex = 1;
            this.radioButtonTypeSequential.TabStop = true;
            this.radioButtonTypeSequential.Text = "Sequential";
            this.radioButtonTypeSequential.UseVisualStyleBackColor = true;
            this.radioButtonTypeSequential.CheckedChanged += new System.EventHandler(this.radioButtonTypeSequential_CheckedChanged);
            // 
            // radioButtonTypeExponential
            // 
            this.radioButtonTypeExponential.AutoSize = true;
            this.radioButtonTypeExponential.Location = new System.Drawing.Point(87, 19);
            this.radioButtonTypeExponential.Name = "radioButtonTypeExponential";
            this.radioButtonTypeExponential.Size = new System.Drawing.Size(80, 17);
            this.radioButtonTypeExponential.TabIndex = 0;
            this.radioButtonTypeExponential.TabStop = true;
            this.radioButtonTypeExponential.Text = "Exponential";
            this.radioButtonTypeExponential.UseVisualStyleBackColor = true;
            this.radioButtonTypeExponential.CheckedChanged += new System.EventHandler(this.radioButtonTypeExponential_CheckedChanged);
            // 
            // linkLabelInstructions
            // 
            this.linkLabelInstructions.AutoSize = true;
            this.linkLabelInstructions.Location = new System.Drawing.Point(617, 13);
            this.linkLabelInstructions.Name = "linkLabelInstructions";
            this.linkLabelInstructions.Size = new System.Drawing.Size(107, 13);
            this.linkLabelInstructions.TabIndex = 19;
            this.linkLabelInstructions.TabStop = true;
            this.linkLabelInstructions.Text = "Instructions and Help";
            this.linkLabelInstructions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInstructions_LinkClicked);
            // 
            // FormAddBlockVariant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 507);
            this.Controls.Add(this.linkLabelInstructions);
            this.Controls.Add(this.groupBoxModel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAddBlockVariant";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Attribute";
            this.groupBoxTextureGroups.ResumeLayout(false);
            this.groupBoxNewTextureGroup.ResumeLayout(false);
            this.groupBoxNewTextureGroup.PerformLayout();
            this.groupBoxRotation.ResumeLayout(false);
            this.groupBoxRotationY.ResumeLayout(false);
            this.groupBoxRotationY.PerformLayout();
            this.groupBoxRotationX.ResumeLayout(false);
            this.groupBoxRotationX.PerformLayout();
            this.groupBoxModel.ResumeLayout(false);
            this.groupBoxModel.PerformLayout();
            this.groupBoxTexturesSequential.ResumeLayout(false);
            this.groupBoxTexturesSequential.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumVariants)).EndInit();
            this.groupBoxSequentialTexVar.ResumeLayout(false);
            this.groupBoxSequentialTexVar.PerformLayout();
            this.groupBoxSequentialTexConst.ResumeLayout(false);
            this.groupBoxSequentialTexConst.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxTextures;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.Label labelTexture;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.TextBox textBoxTexture;
        private System.Windows.Forms.Label labelParentModel;
        private System.Windows.Forms.TextBox textBoxParentModel;
        private System.Windows.Forms.Button buttonAddTexture;
        private System.Windows.Forms.Label labelOverwrite;
        private System.Windows.Forms.TextBox textBoxOverwrite;
        private System.Windows.Forms.GroupBox groupBoxTextureGroups;
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
        private System.Windows.Forms.GroupBox groupBoxModel;
        private System.Windows.Forms.Button buttonAddRef;
        private System.Windows.Forms.ListBox listBoxFaces;
        private System.Windows.Forms.GroupBox groupBoxNewTextureGroup;
        private System.Windows.Forms.Button buttonAddTextureGroup;
        private System.Windows.Forms.ListBox listBoxTextureGroups;
        private System.Windows.Forms.LinkLabel linkLabelInstructions;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonTypeExponential;
        private System.Windows.Forms.RadioButton radioButtonTypeSequential;
        private System.Windows.Forms.GroupBox groupBoxTexturesSequential;
        private System.Windows.Forms.GroupBox groupBoxSequentialTexConst;
        private System.Windows.Forms.Label labelSeqConstTexture;
        private System.Windows.Forms.ListBox listBoxSeqConst;
        private System.Windows.Forms.Button buttonSeqConstAdd;
        private System.Windows.Forms.TextBox textBoxSeqConstReference;
        private System.Windows.Forms.Label labelSeqConstReference;
        private System.Windows.Forms.TextBox textBoxSeqConstTexture;
        private System.Windows.Forms.GroupBox groupBoxSequentialTexVar;
        private System.Windows.Forms.Button buttonSeqVarAdd;
        private System.Windows.Forms.TextBox textBoxSeqVarReference;
        private System.Windows.Forms.Label labelSeqVarReference;
        private System.Windows.Forms.TextBox textBoxSeqVarTexture;
        private System.Windows.Forms.Label labelSeqVarTexture;
        private System.Windows.Forms.ListBox listBoxSeqVar;
        private System.Windows.Forms.NumericUpDown numericUpDownNumVariants;
        private System.Windows.Forms.Label labelSeqNumVariants;
    }
}