namespace MidiEval.Analyzer.Forms {
	partial class Main {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.TabControl _tabCtrlMain;
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
			System.Windows.Forms.GroupBox groupBox2;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
			this._tabPgInput = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._listFiles1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._btnBrowse1 = new System.Windows.Forms.Button();
			this._cmbBoxGenre1 = new System.Windows.Forms.ComboBox();
			this._listFiles2 = new System.Windows.Forms.ListView();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._cmbBoxGenre2 = new System.Windows.Forms.ComboBox();
			this._btnBrowse2 = new System.Windows.Forms.Button();
			this._btnAnalyze = new System.Windows.Forms.Button();
			this._tabPgOutput = new System.Windows.Forms.TabPage();
			this._tabPgAbout = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
			this.label10 = new System.Windows.Forms.Label();
			this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
			this.label8 = new System.Windows.Forms.Label();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this._openDlgFiles = new System.Windows.Forms.OpenFileDialog();
			_tabCtrlMain = new System.Windows.Forms.TabControl();
			groupBox1 = new System.Windows.Forms.GroupBox();
			flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			groupBox2 = new System.Windows.Forms.GroupBox();
			flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			_tabCtrlMain.SuspendLayout();
			this._tabPgInput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			groupBox1.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			groupBox2.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			this._tabPgAbout.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel11.SuspendLayout();
			this.flowLayoutPanel7.SuspendLayout();
			this.flowLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel5.SuspendLayout();
			this.flowLayoutPanel8.SuspendLayout();
			this.flowLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel9.SuspendLayout();
			this.flowLayoutPanel10.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tabCtrlMain
			// 
			_tabCtrlMain.Controls.Add(this._tabPgInput);
			_tabCtrlMain.Controls.Add(this._tabPgOutput);
			_tabCtrlMain.Controls.Add(this._tabPgAbout);
			_tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			_tabCtrlMain.ItemSize = new System.Drawing.Size(64, 24);
			_tabCtrlMain.Location = new System.Drawing.Point(0, 0);
			_tabCtrlMain.Margin = new System.Windows.Forms.Padding(0);
			_tabCtrlMain.Name = "_tabCtrlMain";
			_tabCtrlMain.Padding = new System.Drawing.Point(0, 0);
			_tabCtrlMain.SelectedIndex = 0;
			_tabCtrlMain.Size = new System.Drawing.Size(552, 493);
			_tabCtrlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			_tabCtrlMain.TabIndex = 0;
			// 
			// _tabPgInput
			// 
			this._tabPgInput.Controls.Add(this.splitContainer1);
			this._tabPgInput.Controls.Add(flowLayoutPanel1);
			this._tabPgInput.Location = new System.Drawing.Point(4, 28);
			this._tabPgInput.Margin = new System.Windows.Forms.Padding(0);
			this._tabPgInput.Name = "_tabPgInput";
			this._tabPgInput.Size = new System.Drawing.Size(544, 461);
			this._tabPgInput.TabIndex = 0;
			this._tabPgInput.Text = "Input";
			this._tabPgInput.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(groupBox1);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(8, 8, 3, 8);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(groupBox2);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 8, 8, 8);
			this.splitContainer1.Size = new System.Drawing.Size(544, 422);
			this.splitContainer1.SplitterDistance = 272;
			this.splitContainer1.SplitterWidth = 2;
			this.splitContainer1.TabIndex = 1;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this._listFiles1);
			groupBox1.Controls.Add(flowLayoutPanel2);
			groupBox1.Controls.Add(this._cmbBoxGenre1);
			groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			groupBox1.Location = new System.Drawing.Point(8, 8);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(8);
			groupBox1.Size = new System.Drawing.Size(261, 406);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Genre 1";
			// 
			// _listFiles1
			// 
			this._listFiles1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
			this._listFiles1.Dock = System.Windows.Forms.DockStyle.Fill;
			this._listFiles1.FullRowSelect = true;
			this._listFiles1.GridLines = true;
			this._listFiles1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this._listFiles1.Location = new System.Drawing.Point(8, 44);
			this._listFiles1.Name = "_listFiles1";
			this._listFiles1.ShowGroups = false;
			this._listFiles1.Size = new System.Drawing.Size(245, 315);
			this._listFiles1.TabIndex = 2;
			this._listFiles1.UseCompatibleStateImageBehavior = false;
			this._listFiles1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Path";
			// 
			// columnHeader5
			// 
			this.columnHeader5.DisplayIndex = 3;
			this.columnHeader5.Text = "Tempo";
			// 
			// columnHeader3
			// 
			this.columnHeader3.DisplayIndex = 1;
			this.columnHeader3.Text = "Key Signature";
			// 
			// columnHeader4
			// 
			this.columnHeader4.DisplayIndex = 2;
			this.columnHeader4.Text = "Time Signature";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Note Count";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.AutoSize = true;
			flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel2.Controls.Add(this._btnBrowse1);
			flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			flowLayoutPanel2.Location = new System.Drawing.Point(8, 359);
			flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			flowLayoutPanel2.Size = new System.Drawing.Size(245, 39);
			flowLayoutPanel2.TabIndex = 1;
			// 
			// _btnBrowse1
			// 
			this._btnBrowse1.AutoSize = true;
			this._btnBrowse1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._btnBrowse1.Location = new System.Drawing.Point(182, 8);
			this._btnBrowse1.Margin = new System.Windows.Forms.Padding(0);
			this._btnBrowse1.Name = "_btnBrowse1";
			this._btnBrowse1.Padding = new System.Windows.Forms.Padding(4);
			this._btnBrowse1.Size = new System.Drawing.Size(63, 31);
			this._btnBrowse1.TabIndex = 0;
			this._btnBrowse1.Text = "Browse";
			this._btnBrowse1.UseVisualStyleBackColor = true;
			this._btnBrowse1.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// _cmbBoxGenre1
			// 
			this._cmbBoxGenre1.Dock = System.Windows.Forms.DockStyle.Top;
			this._cmbBoxGenre1.FormattingEnabled = true;
			this._cmbBoxGenre1.Items.AddRange(new object[] {
            "Jazz",
            "Blues"});
			this._cmbBoxGenre1.Location = new System.Drawing.Point(8, 23);
			this._cmbBoxGenre1.Name = "_cmbBoxGenre1";
			this._cmbBoxGenre1.Size = new System.Drawing.Size(245, 21);
			this._cmbBoxGenre1.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(this._listFiles2);
			groupBox2.Controls.Add(this._cmbBoxGenre2);
			groupBox2.Controls.Add(flowLayoutPanel3);
			groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			groupBox2.Location = new System.Drawing.Point(3, 8);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(8);
			groupBox2.Size = new System.Drawing.Size(259, 406);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Genre 2";
			// 
			// _listFiles2
			// 
			this._listFiles2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12});
			this._listFiles2.Dock = System.Windows.Forms.DockStyle.Fill;
			this._listFiles2.FullRowSelect = true;
			this._listFiles2.GridLines = true;
			this._listFiles2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this._listFiles2.Location = new System.Drawing.Point(8, 44);
			this._listFiles2.Name = "_listFiles2";
			this._listFiles2.ShowGroups = false;
			this._listFiles2.Size = new System.Drawing.Size(243, 315);
			this._listFiles2.TabIndex = 3;
			this._listFiles2.UseCompatibleStateImageBehavior = false;
			this._listFiles2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Path";
			// 
			// columnHeader11
			// 
			this.columnHeader11.DisplayIndex = 3;
			this.columnHeader11.Text = "Tempo";
			// 
			// columnHeader9
			// 
			this.columnHeader9.DisplayIndex = 1;
			this.columnHeader9.Text = "Key Signature";
			// 
			// columnHeader10
			// 
			this.columnHeader10.DisplayIndex = 2;
			this.columnHeader10.Text = "Time Signature";
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Note Count";
			this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// _cmbBoxGenre2
			// 
			this._cmbBoxGenre2.Dock = System.Windows.Forms.DockStyle.Top;
			this._cmbBoxGenre2.FormattingEnabled = true;
			this._cmbBoxGenre2.Items.AddRange(new object[] {
            "Jazz",
            "Blues"});
			this._cmbBoxGenre2.Location = new System.Drawing.Point(8, 23);
			this._cmbBoxGenre2.Name = "_cmbBoxGenre2";
			this._cmbBoxGenre2.Size = new System.Drawing.Size(243, 21);
			this._cmbBoxGenre2.TabIndex = 2;
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.AutoSize = true;
			flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel3.Controls.Add(this._btnBrowse2);
			flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			flowLayoutPanel3.Location = new System.Drawing.Point(8, 359);
			flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			flowLayoutPanel3.Size = new System.Drawing.Size(243, 39);
			flowLayoutPanel3.TabIndex = 1;
			// 
			// _btnBrowse2
			// 
			this._btnBrowse2.AutoSize = true;
			this._btnBrowse2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._btnBrowse2.Location = new System.Drawing.Point(180, 8);
			this._btnBrowse2.Margin = new System.Windows.Forms.Padding(0);
			this._btnBrowse2.Name = "_btnBrowse2";
			this._btnBrowse2.Padding = new System.Windows.Forms.Padding(4);
			this._btnBrowse2.Size = new System.Drawing.Size(63, 31);
			this._btnBrowse2.TabIndex = 0;
			this._btnBrowse2.Text = "Browse";
			this._btnBrowse2.UseVisualStyleBackColor = true;
			this._btnBrowse2.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoSize = true;
			flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel1.Controls.Add(this._btnAnalyze);
			flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			flowLayoutPanel1.Location = new System.Drawing.Point(0, 422);
			flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 8);
			flowLayoutPanel1.Size = new System.Drawing.Size(544, 39);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// _btnAnalyze
			// 
			this._btnAnalyze.AutoSize = true;
			this._btnAnalyze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._btnAnalyze.Location = new System.Drawing.Point(472, 0);
			this._btnAnalyze.Margin = new System.Windows.Forms.Padding(0);
			this._btnAnalyze.Name = "_btnAnalyze";
			this._btnAnalyze.Padding = new System.Windows.Forms.Padding(4);
			this._btnAnalyze.Size = new System.Drawing.Size(64, 31);
			this._btnAnalyze.TabIndex = 0;
			this._btnAnalyze.Text = "Analyze";
			this._btnAnalyze.UseVisualStyleBackColor = true;
			this._btnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
			// 
			// _tabPgOutput
			// 
			this._tabPgOutput.Location = new System.Drawing.Point(4, 28);
			this._tabPgOutput.Margin = new System.Windows.Forms.Padding(0);
			this._tabPgOutput.Name = "_tabPgOutput";
			this._tabPgOutput.Size = new System.Drawing.Size(544, 461);
			this._tabPgOutput.TabIndex = 1;
			this._tabPgOutput.Text = "Output";
			this._tabPgOutput.UseVisualStyleBackColor = true;
			// 
			// _tabPgAbout
			// 
			this._tabPgAbout.Controls.Add(this.panel1);
			this._tabPgAbout.Location = new System.Drawing.Point(4, 28);
			this._tabPgAbout.Name = "_tabPgAbout";
			this._tabPgAbout.Padding = new System.Windows.Forms.Padding(3);
			this._tabPgAbout.Size = new System.Drawing.Size(544, 461);
			this._tabPgAbout.TabIndex = 2;
			this._tabPgAbout.Text = "About";
			this._tabPgAbout.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.flowLayoutPanel11);
			this.panel1.Controls.Add(this.flowLayoutPanel7);
			this.panel1.Controls.Add(this.flowLayoutPanel6);
			this.panel1.Controls.Add(this.flowLayoutPanel5);
			this.panel1.Controls.Add(this.flowLayoutPanel8);
			this.panel1.Controls.Add(this.flowLayoutPanel4);
			this.panel1.Controls.Add(this.flowLayoutPanel9);
			this.panel1.Controls.Add(this.flowLayoutPanel10);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(32, 48, 32, 8);
			this.panel1.Size = new System.Drawing.Size(538, 455);
			this.panel1.TabIndex = 8;
			// 
			// flowLayoutPanel11
			// 
			this.flowLayoutPanel11.AutoSize = true;
			this.flowLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel11.Controls.Add(this.label10);
			this.flowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel11.Location = new System.Drawing.Point(32, 338);
			this.flowLayoutPanel11.Name = "flowLayoutPanel11";
			this.flowLayoutPanel11.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.flowLayoutPanel11.Size = new System.Drawing.Size(474, 41);
			this.flowLayoutPanel11.TabIndex = 13;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Top;
			this.label10.Location = new System.Drawing.Point(0, 24);
			this.label10.Margin = new System.Windows.Forms.Padding(0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(109, 17);
			this.label10.TabIndex = 7;
			this.label10.Text = "2015 February 27";
			// 
			// flowLayoutPanel7
			// 
			this.flowLayoutPanel7.AutoSize = true;
			this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel7.Controls.Add(this.label8);
			this.flowLayoutPanel7.Controls.Add(this.linkLabel3);
			this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel7.Location = new System.Drawing.Point(32, 297);
			this.flowLayoutPanel7.Name = "flowLayoutPanel7";
			this.flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.flowLayoutPanel7.Size = new System.Drawing.Size(474, 41);
			this.flowLayoutPanel7.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Location = new System.Drawing.Point(0, 24);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(257, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "MIDIEval is licensed under the MIT License.";
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Location = new System.Drawing.Point(260, 24);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(81, 17);
			this.linkLabel3.TabIndex = 8;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "View License";
			// 
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.AutoSize = true;
			this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel6.Controls.Add(this.label7);
			this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel6.Location = new System.Drawing.Point(32, 256);
			this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.flowLayoutPanel6.Size = new System.Drawing.Size(474, 41);
			this.flowLayoutPanel6.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(0, 24);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(377, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Using Leslie Sanford\'s MIDI Toolkit (2007 April 19), MIT License.";
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.AutoSize = true;
			this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel5.Controls.Add(this.label4);
			this.flowLayoutPanel5.Controls.Add(this.label5);
			this.flowLayoutPanel5.Controls.Add(this.label6);
			this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel5.Location = new System.Drawing.Point(32, 164);
			this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.flowLayoutPanel5.Size = new System.Drawing.Size(474, 92);
			this.flowLayoutPanel5.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(0, 24);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "For our thesis paper";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(0, 41);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(466, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "\"Trends of Music through Analysis and Comparison of Musical Structures\"";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(0, 58);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(441, 34);
			this.label6.TabIndex = 6;
			this.label6.Text = "by Crisostomo, Allan V.; Doydora, Jonathan L.; Bragais, Alvin; and Legarte, Kenne" +
    "dy.";
			// 
			// flowLayoutPanel8
			// 
			this.flowLayoutPanel8.AutoSize = true;
			this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel8.Controls.Add(this.linkLabel2);
			this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel8.Location = new System.Drawing.Point(32, 147);
			this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel8.Name = "flowLayoutPanel8";
			this.flowLayoutPanel8.Size = new System.Drawing.Size(474, 17);
			this.flowLayoutPanel8.TabIndex = 10;
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.linkLabel2.Location = new System.Drawing.Point(0, 0);
			this.linkLabel2.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(190, 17);
			this.linkLabel2.TabIndex = 3;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "https://github.com/Temoto-kun";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.AutoSize = true;
			this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel4.Controls.Add(this.label3);
			this.flowLayoutPanel4.Controls.Add(this.linkLabel1);
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(32, 130);
			this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(474, 17);
			this.flowLayoutPanel4.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Allan V. Crisostomo";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(122, 0);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(181, 17);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "allan.crisostomo@pup.edu.ph";
			// 
			// flowLayoutPanel9
			// 
			this.flowLayoutPanel9.AutoSize = true;
			this.flowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel9.Controls.Add(this.label2);
			this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel9.Location = new System.Drawing.Point(32, 113);
			this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel9.Name = "flowLayoutPanel9";
			this.flowLayoutPanel9.Size = new System.Drawing.Size(474, 17);
			this.flowLayoutPanel9.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Developed by:";
			// 
			// flowLayoutPanel10
			// 
			this.flowLayoutPanel10.AutoSize = true;
			this.flowLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel10.Controls.Add(this.label1);
			this.flowLayoutPanel10.Controls.Add(this.label9);
			this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
			this.flowLayoutPanel10.Location = new System.Drawing.Point(32, 48);
			this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel10.Name = "flowLayoutPanel10";
			this.flowLayoutPanel10.Size = new System.Drawing.Size(474, 65);
			this.flowLayoutPanel10.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "MIDIEval";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Top;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(202, 34);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label9.Size = new System.Drawing.Size(54, 31);
			this.label9.TabIndex = 1;
			this.label9.Text = "v.0.0.1";
			// 
			// _openDlgFiles
			// 
			this._openDlgFiles.DefaultExt = "mid";
			this._openDlgFiles.FileName = "openFileDialog1";
			this._openDlgFiles.Filter = "MIDI Files|*.mid";
			this._openDlgFiles.Multiselect = true;
			this._openDlgFiles.RestoreDirectory = true;
			this._openDlgFiles.SupportMultiDottedExtensions = true;
			this._openDlgFiles.Title = "Open MIDI Files";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 493);
			this.Controls.Add(_tabCtrlMain);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MIDIEval";
			_tabCtrlMain.ResumeLayout(false);
			this._tabPgInput.ResumeLayout(false);
			this._tabPgInput.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			flowLayoutPanel3.ResumeLayout(false);
			flowLayoutPanel3.PerformLayout();
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			this._tabPgAbout.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel11.ResumeLayout(false);
			this.flowLayoutPanel11.PerformLayout();
			this.flowLayoutPanel7.ResumeLayout(false);
			this.flowLayoutPanel7.PerformLayout();
			this.flowLayoutPanel6.ResumeLayout(false);
			this.flowLayoutPanel6.PerformLayout();
			this.flowLayoutPanel5.ResumeLayout(false);
			this.flowLayoutPanel5.PerformLayout();
			this.flowLayoutPanel8.ResumeLayout(false);
			this.flowLayoutPanel8.PerformLayout();
			this.flowLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel4.PerformLayout();
			this.flowLayoutPanel9.ResumeLayout(false);
			this.flowLayoutPanel9.PerformLayout();
			this.flowLayoutPanel10.ResumeLayout(false);
			this.flowLayoutPanel10.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage _tabPgInput;
		private System.Windows.Forms.TabPage _tabPgOutput;
		private System.Windows.Forms.Button _btnAnalyze;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button _btnBrowse1;
		private System.Windows.Forms.ComboBox _cmbBoxGenre1;
		private System.Windows.Forms.Button _btnBrowse2;
		private System.Windows.Forms.ComboBox _cmbBoxGenre2;
		private System.Windows.Forms.ListView _listFiles1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ListView _listFiles2;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.TabPage _tabPgAbout;
		private System.Windows.Forms.OpenFileDialog _openDlgFiles;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.LinkLabel linkLabel3;
	}
}