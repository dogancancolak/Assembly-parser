namespace Assembly
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AssemblyCode = new System.Windows.Forms.ListBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.oppcodeBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.IBox = new System.Windows.Forms.TextBox();
            this.commentbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.oppcodeLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.lineCounter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ARLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PCLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StackSegment = new System.Windows.Forms.DataGridView();
            this.StackAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StackDataBIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StackDataHEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSegment = new System.Windows.Forms.DataGridView();
            this.DataAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDataBIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDataHEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeSegment = new System.Windows.Forms.DataGridView();
            this.AddressCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeDataBIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeDataHEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.LabelGrid = new System.Windows.Forms.DataGridView();
            this.LabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MO1 = new System.Windows.Forms.Label();
            this.MO2 = new System.Windows.Forms.Label();
            this.MO3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StackSegment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSegment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeSegment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assembly File";
            // 
            // BrowseBox
            // 
            this.BrowseBox.Location = new System.Drawing.Point(726, 12);
            this.BrowseBox.Name = "BrowseBox";
            this.BrowseBox.Size = new System.Drawing.Size(490, 22);
            this.BrowseBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(574, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 33);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssemblyCode
            // 
            this.AssemblyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssemblyCode.Enabled = false;
            this.AssemblyCode.FormattingEnabled = true;
            this.AssemblyCode.ItemHeight = 16;
            this.AssemblyCode.Location = new System.Drawing.Point(12, 12);
            this.AssemblyCode.Name = "AssemblyCode";
            this.AssemblyCode.Size = new System.Drawing.Size(356, 324);
            this.AssemblyCode.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.BackColor = System.Drawing.Color.Firebrick;
            this.ParseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ParseButton.Location = new System.Drawing.Point(427, 12);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(79, 28);
            this.ParseButton.TabIndex = 4;
            this.ParseButton.Text = "Parse it !!";
            this.ParseButton.UseVisualStyleBackColor = false;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // labelBox
            // 
            this.labelBox.BackColor = System.Drawing.SystemColors.Control;
            this.labelBox.CausesValidation = false;
            this.labelBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelBox.Location = new System.Drawing.Point(79, 564);
            this.labelBox.Name = "labelBox";
            this.labelBox.ReadOnly = true;
            this.labelBox.Size = new System.Drawing.Size(289, 22);
            this.labelBox.TabIndex = 5;
            this.labelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oppcodeBox
            // 
            this.oppcodeBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.oppcodeBox.Location = new System.Drawing.Point(79, 592);
            this.oppcodeBox.Name = "oppcodeBox";
            this.oppcodeBox.ReadOnly = true;
            this.oppcodeBox.Size = new System.Drawing.Size(289, 22);
            this.oppcodeBox.TabIndex = 6;
            this.oppcodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addressBox
            // 
            this.addressBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addressBox.Location = new System.Drawing.Point(79, 620);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(289, 22);
            this.addressBox.TabIndex = 7;
            this.addressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IBox
            // 
            this.IBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IBox.Location = new System.Drawing.Point(79, 648);
            this.IBox.Name = "IBox";
            this.IBox.ReadOnly = true;
            this.IBox.Size = new System.Drawing.Size(289, 22);
            this.IBox.TabIndex = 8;
            this.IBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // commentbox
            // 
            this.commentbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.commentbox.Location = new System.Drawing.Point(79, 676);
            this.commentbox.Name = "commentbox";
            this.commentbox.ReadOnly = true;
            this.commentbox.Size = new System.Drawing.Size(289, 22);
            this.commentbox.TabIndex = 9;
            this.commentbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Choose Your File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Assembly Code";
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.Location = new System.Drawing.Point(27, 568);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelLabel.Size = new System.Drawing.Size(43, 17);
            this.labelLabel.TabIndex = 11;
            this.labelLabel.Text = "Label";
            // 
            // oppcodeLabel
            // 
            this.oppcodeLabel.AutoSize = true;
            this.oppcodeLabel.Location = new System.Drawing.Point(5, 595);
            this.oppcodeLabel.Name = "oppcodeLabel";
            this.oppcodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.oppcodeLabel.Size = new System.Drawing.Size(68, 17);
            this.oppcodeLabel.TabIndex = 12;
            this.oppcodeLabel.Text = "OppCode";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 623);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Address";
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(56, 653);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(11, 17);
            this.ILabel.TabIndex = 14;
            this.ILabel.Text = "I";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(6, 679);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(67, 17);
            this.commentLabel.TabIndex = 15;
            this.commentLabel.Text = "Comment";
            // 
            // lineCounter
            // 
            this.lineCounter.AutoSize = true;
            this.lineCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineCounter.Location = new System.Drawing.Point(166, 701);
            this.lineCounter.Name = "lineCounter";
            this.lineCounter.Size = new System.Drawing.Size(73, 19);
            this.lineCounter.TabIndex = 16;
            this.lineCounter.Text = "Line : ???";
            this.lineCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.ARLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PCLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(374, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 293);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(353, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 19);
            this.label18.TabIndex = 15;
            this.label18.Text = "label18";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(230, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Output Register :";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(354, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 19);
            this.label16.TabIndex = 13;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(243, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Input Register :";
            // 
            // ARLabel
            // 
            this.ARLabel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ARLabel.Location = new System.Drawing.Point(137, 53);
            this.ARLabel.Name = "ARLabel";
            this.ARLabel.Size = new System.Drawing.Size(75, 23);
            this.ARLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address Register :";
            // 
            // PCLabel
            // 
            this.PCLabel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.PCLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCLabel.Location = new System.Drawing.Point(137, 22);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(75, 23);
            this.PCLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Program Counter :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MO3);
            this.groupBox2.Controls.Add(this.MO2);
            this.groupBox2.Controls.Add(this.MO1);
            this.groupBox2.Location = new System.Drawing.Point(862, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 152);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Micro Operations";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(862, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 126);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flags";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(212, 94);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 17);
            this.label32.TabIndex = 9;
            this.label32.Text = "label32";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(110, 94);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(95, 17);
            this.label31.TabIndex = 8;
            this.label31.Text = "OVERFLOW :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(313, 61);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 17);
            this.label30.TabIndex = 7;
            this.label30.Text = "label30";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(313, 36);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 17);
            this.label29.TabIndex = 6;
            this.label29.Text = "label29";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(251, 62);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 17);
            this.label28.TabIndex = 5;
            this.label28.Text = "ZERO :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(248, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 17);
            this.label27.TabIndex = 4;
            this.label27.Text = "CARRY :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(91, 61);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 17);
            this.label26.TabIndex = 3;
            this.label26.Text = "label26";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(90, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 17);
            this.label25.TabIndex = 2;
            this.label25.Text = "label25";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(34, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "FULL :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 17);
            this.label23.TabIndex = 0;
            this.label23.Text = "EMPTY :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.StackSegment);
            this.groupBox4.Controls.Add(this.DataSegment);
            this.groupBox4.Controls.Add(this.CodeSegment);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Location = new System.Drawing.Point(374, 343);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(880, 377);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Memories";
            // 
            // StackSegment
            // 
            this.StackSegment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StackSegment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StackAddress,
            this.StackDataBIN,
            this.StackDataHEX});
            this.StackSegment.Location = new System.Drawing.Point(590, 92);
            this.StackSegment.Name = "StackSegment";
            this.StackSegment.RowTemplate.Height = 24;
            this.StackSegment.Size = new System.Drawing.Size(279, 261);
            this.StackSegment.TabIndex = 6;
            // 
            // StackAddress
            // 
            this.StackAddress.HeaderText = "Address";
            this.StackAddress.Name = "StackAddress";
            // 
            // StackDataBIN
            // 
            this.StackDataBIN.HeaderText = "Data(BIN)";
            this.StackDataBIN.Name = "StackDataBIN";
            // 
            // StackDataHEX
            // 
            this.StackDataHEX.HeaderText = "Data(HEX)";
            this.StackDataHEX.Name = "StackDataHEX";
            // 
            // DataSegment
            // 
            this.DataSegment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSegment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataAddress,
            this.DataDataBIN,
            this.DataDataHEX});
            this.DataSegment.Location = new System.Drawing.Point(307, 92);
            this.DataSegment.Name = "DataSegment";
            this.DataSegment.RowTemplate.Height = 24;
            this.DataSegment.Size = new System.Drawing.Size(280, 261);
            this.DataSegment.TabIndex = 5;
            // 
            // DataAddress
            // 
            this.DataAddress.HeaderText = "Address";
            this.DataAddress.Name = "DataAddress";
            // 
            // DataDataBIN
            // 
            this.DataDataBIN.HeaderText = "Data(BIN)";
            this.DataDataBIN.Name = "DataDataBIN";
            // 
            // DataDataHEX
            // 
            this.DataDataHEX.HeaderText = "Data(HEX)";
            this.DataDataHEX.Name = "DataDataHEX";
            // 
            // CodeSegment
            // 
            this.CodeSegment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CodeSegment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddressCode,
            this.CodeDataBIN,
            this.CodeDataHEX});
            this.CodeSegment.Location = new System.Drawing.Point(19, 92);
            this.CodeSegment.Name = "CodeSegment";
            this.CodeSegment.RowTemplate.Height = 24;
            this.CodeSegment.Size = new System.Drawing.Size(280, 261);
            this.CodeSegment.TabIndex = 4;
            // 
            // AddressCode
            // 
            this.AddressCode.HeaderText = "Address";
            this.AddressCode.Name = "AddressCode";
            // 
            // CodeDataBIN
            // 
            this.CodeDataBIN.HeaderText = "Data(BIN)";
            this.CodeDataBIN.Name = "CodeDataBIN";
            // 
            // CodeDataHEX
            // 
            this.CodeDataHEX.HeaderText = "Data(HEX)";
            this.CodeDataHEX.Name = "CodeDataHEX";
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Location = new System.Drawing.Point(393, 46);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(75, 23);
            this.label36.TabIndex = 3;
            this.label36.Text = "label36";
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Location = new System.Drawing.Point(315, 46);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 23);
            this.label35.TabIndex = 2;
            this.label35.Text = "label35";
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(393, 22);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(72, 23);
            this.label34.TabIndex = 1;
            this.label34.Text = "Value";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(315, 25);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(72, 17);
            this.label33.TabIndex = 0;
            this.label33.Text = "OpCode";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelGrid
            // 
            this.LabelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LabelGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabelName,
            this.LabelAddress});
            this.LabelGrid.Location = new System.Drawing.Point(12, 368);
            this.LabelGrid.Name = "LabelGrid";
            this.LabelGrid.RowTemplate.Height = 24;
            this.LabelGrid.Size = new System.Drawing.Size(356, 150);
            this.LabelGrid.TabIndex = 21;
            // 
            // LabelName
            // 
            this.LabelName.HeaderText = "Name";
            this.LabelName.Name = "LabelName";
            this.LabelName.Width = 106;
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LabelAddress.HeaderText = "Address";
            this.LabelAddress.Name = "LabelAddress";
            // 
            // MO1
            // 
            this.MO1.AutoSize = true;
            this.MO1.Location = new System.Drawing.Point(34, 34);
            this.MO1.Name = "MO1";
            this.MO1.Size = new System.Drawing.Size(128, 17);
            this.MO1.TabIndex = 0;
            this.MO1.Text = "Micro Operations 1";
            // 
            // MO2
            // 
            this.MO2.AutoSize = true;
            this.MO2.Location = new System.Drawing.Point(34, 69);
            this.MO2.Name = "MO2";
            this.MO2.Size = new System.Drawing.Size(128, 17);
            this.MO2.TabIndex = 1;
            this.MO2.Text = "Micro Operations 2";
            // 
            // MO3
            // 
            this.MO3.AutoSize = true;
            this.MO3.Location = new System.Drawing.Point(37, 101);
            this.MO3.Name = "MO3";
            this.MO3.Size = new System.Drawing.Size(12, 17);
            this.MO3.TabIndex = 2;
            this.MO3.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1266, 734);
            this.Controls.Add(this.LabelGrid);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lineCounter);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.ILabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.oppcodeLabel);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commentbox);
            this.Controls.Add(this.IBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.oppcodeBox);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.AssemblyCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BrowseBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assembler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StackSegment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSegment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeSegment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BrowseBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox AssemblyCode;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox labelBox;
        private System.Windows.Forms.TextBox oppcodeBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox IBox;
        private System.Windows.Forms.TextBox commentbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label oppcodeLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label lineCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PCLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ARLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView StackSegment;
        private System.Windows.Forms.DataGridViewTextBoxColumn StackAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StackDataBIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn StackDataHEX;
        private System.Windows.Forms.DataGridView DataSegment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDataBIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDataHEX;
        private System.Windows.Forms.DataGridView CodeSegment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeDataBIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeDataHEX;
        private System.Windows.Forms.DataGridView LabelGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelAddress;
        private System.Windows.Forms.Label MO2;
        private System.Windows.Forms.Label MO1;
        private System.Windows.Forms.Label MO3;
    }
}

