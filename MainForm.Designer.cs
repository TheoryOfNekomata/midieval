namespace MidiEval {
	partial class MainForm {
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
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
			System.Windows.Forms.Panel panel1;
			System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.SplitContainer splitContainer1;
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
			System.Windows.Forms.GroupBox groupBox2;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
			System.Windows.Forms.ColumnHeader columnHeader1;
			System.Windows.Forms.ColumnHeader columnHeader2;
			System.Windows.Forms.ColumnHeader columnHeader3;
			System.Windows.Forms.ColumnHeader columnHeader4;
			this.BtnAnalyze = new System.Windows.Forms.Button();
			this.PanelInvalidInput = new System.Windows.Forms.TableLayoutPanel();
			this.BtnGoBack = new System.Windows.Forms.Button();
			this.ListFiles1 = new System.Windows.Forms.ListView();
			this.CmbBoxGenre1 = new System.Windows.Forms.ComboBox();
			this.BtnBrowse1 = new System.Windows.Forms.Button();
			this.ListFiles2 = new System.Windows.Forms.ListView();
			this.CmbBoxGenre2 = new System.Windows.Forms.ComboBox();
			this.BtnBrowse2 = new System.Windows.Forms.Button();
			this.TabCtrlMain = new System.Windows.Forms.TabControl();
			this.TabPgInput = new System.Windows.Forms.TabPage();
			this.TabPgOutput = new System.Windows.Forms.TabPage();
			this.TabPgAbout = new System.Windows.Forms.TabPage();
			this.OpenFileDlgInput = new System.Windows.Forms.OpenFileDialog();
			flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			panel1 = new System.Windows.Forms.Panel();
			tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			label1 = new System.Windows.Forms.Label();
			splitContainer1 = new System.Windows.Forms.SplitContainer();
			groupBox1 = new System.Windows.Forms.GroupBox();
			flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			groupBox2 = new System.Windows.Forms.GroupBox();
			flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			flowLayoutPanel1.SuspendLayout();
			this.PanelInvalidInput.SuspendLayout();
			panel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			groupBox1.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			groupBox2.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			this.TabCtrlMain.SuspendLayout();
			this.TabPgInput.SuspendLayout();
			this.TabPgOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoSize = true;
			flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel1.Controls.Add(this.BtnAnalyze);
			flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			flowLayoutPanel1.Location = new System.Drawing.Point(0, 181);
			flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 8);
			flowLayoutPanel1.Size = new System.Drawing.Size(302, 39);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// BtnAnalyze
			// 
			this.BtnAnalyze.AutoSize = true;
			this.BtnAnalyze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtnAnalyze.Location = new System.Drawing.Point(224, 0);
			this.BtnAnalyze.Margin = new System.Windows.Forms.Padding(0);
			this.BtnAnalyze.Name = "BtnAnalyze";
			this.BtnAnalyze.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
			this.BtnAnalyze.Size = new System.Drawing.Size(70, 31);
			this.BtnAnalyze.TabIndex = 0;
			this.BtnAnalyze.Text = "Analyze";
			this.BtnAnalyze.UseVisualStyleBackColor = true;
			this.BtnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
			// 
			// PanelInvalidInput
			// 
			this.PanelInvalidInput.ColumnCount = 3;
			this.PanelInvalidInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.PanelInvalidInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.PanelInvalidInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.PanelInvalidInput.Controls.Add(panel1, 1, 1);
			this.PanelInvalidInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelInvalidInput.Location = new System.Drawing.Point(3, 3);
			this.PanelInvalidInput.Name = "PanelInvalidInput";
			this.PanelInvalidInput.RowCount = 3;
			this.PanelInvalidInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.PanelInvalidInput.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.PanelInvalidInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.PanelInvalidInput.Size = new System.Drawing.Size(296, 214);
			this.PanelInvalidInput.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(tableLayoutPanel2);
			panel1.Controls.Add(label1);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Location = new System.Drawing.Point(77, 57);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(142, 100);
			panel1.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.AutoSize = true;
			tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			tableLayoutPanel2.Controls.Add(this.BtnGoBack, 1, 0);
			tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel2.Location = new System.Drawing.Point(0, 68);
			tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel2.Size = new System.Drawing.Size(142, 32);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// BtnGoBack
			// 
			this.BtnGoBack.AutoSize = true;
			this.BtnGoBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtnGoBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnGoBack.Location = new System.Drawing.Point(14, 0);
			this.BtnGoBack.Margin = new System.Windows.Forms.Padding(0);
			this.BtnGoBack.Name = "BtnGoBack";
			this.BtnGoBack.Size = new System.Drawing.Size(113, 32);
			this.BtnGoBack.TabIndex = 0;
			this.BtnGoBack.Text = "Go Back to Input";
			this.BtnGoBack.UseVisualStyleBackColor = true;
			this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
			// 
			// label1
			// 
			label1.Dock = System.Windows.Forms.DockStyle.Top;
			label1.Location = new System.Drawing.Point(0, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(142, 68);
			label1.TabIndex = 1;
			label1.Text = "Please check that your inputs are valid MIDI files.";
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new System.Drawing.Point(0, 0);
			splitContainer1.Margin = new System.Windows.Forms.Padding(0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(groupBox1);
			splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(8, 8, 3, 8);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(groupBox2);
			splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 8, 8, 8);
			splitContainer1.Size = new System.Drawing.Size(302, 181);
			splitContainer1.SplitterDistance = 151;
			splitContainer1.SplitterWidth = 2;
			splitContainer1.TabIndex = 1;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.ListFiles1);
			groupBox1.Controls.Add(this.CmbBoxGenre1);
			groupBox1.Controls.Add(flowLayoutPanel2);
			groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			groupBox1.Location = new System.Drawing.Point(8, 8);
			groupBox1.Margin = new System.Windows.Forms.Padding(0);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
			groupBox1.Size = new System.Drawing.Size(140, 165);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Genre 1";
			// 
			// ListFiles1
			// 
			this.ListFiles1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2});
			this.ListFiles1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListFiles1.FullRowSelect = true;
			this.ListFiles1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.ListFiles1.Location = new System.Drawing.Point(12, 42);
			this.ListFiles1.Margin = new System.Windows.Forms.Padding(0);
			this.ListFiles1.Name = "ListFiles1";
			this.ListFiles1.ShowGroups = false;
			this.ListFiles1.Size = new System.Drawing.Size(116, 76);
			this.ListFiles1.TabIndex = 2;
			this.ListFiles1.UseCompatibleStateImageBehavior = false;
			this.ListFiles1.View = System.Windows.Forms.View.Details;
			// 
			// CmbBoxGenre1
			// 
			this.CmbBoxGenre1.Dock = System.Windows.Forms.DockStyle.Top;
			this.CmbBoxGenre1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbBoxGenre1.FormattingEnabled = true;
			this.CmbBoxGenre1.Items.AddRange(new object[] {
            "Jazz",
            "Blues"});
			this.CmbBoxGenre1.Location = new System.Drawing.Point(12, 21);
			this.CmbBoxGenre1.Margin = new System.Windows.Forms.Padding(0);
			this.CmbBoxGenre1.Name = "CmbBoxGenre1";
			this.CmbBoxGenre1.Size = new System.Drawing.Size(116, 21);
			this.CmbBoxGenre1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.AutoSize = true;
			flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel2.Controls.Add(this.BtnBrowse1);
			flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			flowLayoutPanel2.Location = new System.Drawing.Point(12, 118);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Size = new System.Drawing.Size(116, 39);
			flowLayoutPanel2.TabIndex = 1;
			// 
			// BtnBrowse1
			// 
			this.BtnBrowse1.AutoSize = true;
			this.BtnBrowse1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtnBrowse1.Location = new System.Drawing.Point(48, 8);
			this.BtnBrowse1.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.BtnBrowse1.Name = "BtnBrowse1";
			this.BtnBrowse1.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
			this.BtnBrowse1.Size = new System.Drawing.Size(68, 31);
			this.BtnBrowse1.TabIndex = 0;
			this.BtnBrowse1.Text = "Browse";
			this.BtnBrowse1.UseVisualStyleBackColor = true;
			this.BtnBrowse1.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(this.ListFiles2);
			groupBox2.Controls.Add(this.CmbBoxGenre2);
			groupBox2.Controls.Add(flowLayoutPanel3);
			groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			groupBox2.Location = new System.Drawing.Point(3, 8);
			groupBox2.Margin = new System.Windows.Forms.Padding(0);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
			groupBox2.Size = new System.Drawing.Size(138, 165);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "Genre 2";
			// 
			// ListFiles2
			// 
			this.ListFiles2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader3,
            columnHeader4});
			this.ListFiles2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListFiles2.FullRowSelect = true;
			this.ListFiles2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.ListFiles2.Location = new System.Drawing.Point(12, 42);
			this.ListFiles2.Margin = new System.Windows.Forms.Padding(0);
			this.ListFiles2.Name = "ListFiles2";
			this.ListFiles2.ShowGroups = false;
			this.ListFiles2.Size = new System.Drawing.Size(114, 76);
			this.ListFiles2.TabIndex = 3;
			this.ListFiles2.UseCompatibleStateImageBehavior = false;
			this.ListFiles2.View = System.Windows.Forms.View.Details;
			// 
			// CmbBoxGenre2
			// 
			this.CmbBoxGenre2.Dock = System.Windows.Forms.DockStyle.Top;
			this.CmbBoxGenre2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CmbBoxGenre2.FormattingEnabled = true;
			this.CmbBoxGenre2.Items.AddRange(new object[] {
            "Jazz",
            "Blues"});
			this.CmbBoxGenre2.Location = new System.Drawing.Point(12, 21);
			this.CmbBoxGenre2.Margin = new System.Windows.Forms.Padding(0);
			this.CmbBoxGenre2.Name = "CmbBoxGenre2";
			this.CmbBoxGenre2.Size = new System.Drawing.Size(114, 21);
			this.CmbBoxGenre2.TabIndex = 1;
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.AutoSize = true;
			flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel3.Controls.Add(this.BtnBrowse2);
			flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			flowLayoutPanel3.Location = new System.Drawing.Point(12, 118);
			flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new System.Drawing.Size(114, 39);
			flowLayoutPanel3.TabIndex = 2;
			// 
			// BtnBrowse2
			// 
			this.BtnBrowse2.AutoSize = true;
			this.BtnBrowse2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtnBrowse2.Location = new System.Drawing.Point(46, 8);
			this.BtnBrowse2.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.BtnBrowse2.Name = "BtnBrowse2";
			this.BtnBrowse2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
			this.BtnBrowse2.Size = new System.Drawing.Size(68, 31);
			this.BtnBrowse2.TabIndex = 0;
			this.BtnBrowse2.Text = "Browse";
			this.BtnBrowse2.UseVisualStyleBackColor = true;
			this.BtnBrowse2.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// TabCtrlMain
			// 
			this.TabCtrlMain.Controls.Add(this.TabPgInput);
			this.TabCtrlMain.Controls.Add(this.TabPgOutput);
			this.TabCtrlMain.Controls.Add(this.TabPgAbout);
			this.TabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabCtrlMain.ItemSize = new System.Drawing.Size(64, 32);
			this.TabCtrlMain.Location = new System.Drawing.Point(0, 0);
			this.TabCtrlMain.Margin = new System.Windows.Forms.Padding(0);
			this.TabCtrlMain.Name = "TabCtrlMain";
			this.TabCtrlMain.Padding = new System.Drawing.Point(0, 0);
			this.TabCtrlMain.SelectedIndex = 0;
			this.TabCtrlMain.Size = new System.Drawing.Size(310, 260);
			this.TabCtrlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.TabCtrlMain.TabIndex = 0;
			// 
			// TabPgInput
			// 
			this.TabPgInput.Controls.Add(splitContainer1);
			this.TabPgInput.Controls.Add(flowLayoutPanel1);
			this.TabPgInput.Location = new System.Drawing.Point(4, 36);
			this.TabPgInput.Margin = new System.Windows.Forms.Padding(0);
			this.TabPgInput.Name = "TabPgInput";
			this.TabPgInput.Size = new System.Drawing.Size(302, 220);
			this.TabPgInput.TabIndex = 0;
			this.TabPgInput.Text = "Input";
			this.TabPgInput.UseVisualStyleBackColor = true;
			// 
			// TabPgOutput
			// 
			this.TabPgOutput.Controls.Add(this.PanelInvalidInput);
			this.TabPgOutput.Location = new System.Drawing.Point(4, 36);
			this.TabPgOutput.Name = "TabPgOutput";
			this.TabPgOutput.Padding = new System.Windows.Forms.Padding(3);
			this.TabPgOutput.Size = new System.Drawing.Size(302, 220);
			this.TabPgOutput.TabIndex = 1;
			this.TabPgOutput.Text = "Output";
			this.TabPgOutput.UseVisualStyleBackColor = true;
			// 
			// TabPgAbout
			// 
			this.TabPgAbout.Location = new System.Drawing.Point(4, 36);
			this.TabPgAbout.Name = "TabPgAbout";
			this.TabPgAbout.Padding = new System.Windows.Forms.Padding(3);
			this.TabPgAbout.Size = new System.Drawing.Size(302, 220);
			this.TabPgAbout.TabIndex = 2;
			this.TabPgAbout.Text = "About";
			this.TabPgAbout.UseVisualStyleBackColor = true;
			// 
			// OpenFileDlgInput
			// 
			this.OpenFileDlgInput.DefaultExt = "mid";
			this.OpenFileDlgInput.FileName = "MIDIFile";
			this.OpenFileDlgInput.Filter = "MIDI files|*.mid;*.midi";
			this.OpenFileDlgInput.Multiselect = true;
			this.OpenFileDlgInput.RestoreDirectory = true;
			this.OpenFileDlgInput.SupportMultiDottedExtensions = true;
			this.OpenFileDlgInput.Title = "Open MIDI Files";
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Name";
			columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Note Count";
			columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Name";
			columnHeader3.Width = 200;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Note Count";
			columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 260);
			this.Controls.Add(this.TabCtrlMain);
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MIDI Analyzer";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			this.PanelInvalidInput.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
			splitContainer1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			flowLayoutPanel3.ResumeLayout(false);
			flowLayoutPanel3.PerformLayout();
			this.TabCtrlMain.ResumeLayout(false);
			this.TabPgInput.ResumeLayout(false);
			this.TabPgInput.PerformLayout();
			this.TabPgOutput.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabCtrlMain;
		private System.Windows.Forms.TabPage TabPgInput;
		private System.Windows.Forms.TabPage TabPgOutput;
		private System.Windows.Forms.Button BtnGoBack;
		private System.Windows.Forms.ComboBox CmbBoxGenre1;
		private System.Windows.Forms.ComboBox CmbBoxGenre2;
		private System.Windows.Forms.OpenFileDialog OpenFileDlgInput;
		public System.Windows.Forms.Button BtnAnalyze;
		public System.Windows.Forms.Button BtnBrowse1;
		public System.Windows.Forms.Button BtnBrowse2;
		public System.Windows.Forms.ListView ListFiles1;
		public System.Windows.Forms.ListView ListFiles2;
		private System.Windows.Forms.TabPage TabPgAbout;
		private System.Windows.Forms.TableLayoutPanel PanelInvalidInput;
	}
}

