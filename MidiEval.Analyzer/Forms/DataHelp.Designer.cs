namespace MidiEval.Analyzer.Forms {
	partial class DataHelp {
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
			System.Windows.Forms.Label label3;
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
			System.Windows.Forms.Button _btnClose;
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataHelp));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			label3 = new System.Windows.Forms.Label();
			flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			_btnClose = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			flowLayoutPanel2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			label3.AutoEllipsis = true;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI Light", 24F);
			label3.Location = new System.Drawing.Point(0, 0);
			label3.Margin = new System.Windows.Forms.Padding(0);
			label3.Name = "label3";
			label3.Padding = new System.Windows.Forms.Padding(56, 32, 56, 0);
			label3.Size = new System.Drawing.Size(496, 77);
			label3.TabIndex = 2;
			label3.Text = "What do these data mean?";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.AutoSize = true;
			flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			flowLayoutPanel2.Controls.Add(_btnClose);
			flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			flowLayoutPanel2.Location = new System.Drawing.Point(0, 213);
			flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
			flowLayoutPanel2.Size = new System.Drawing.Size(589, 47);
			flowLayoutPanel2.TabIndex = 4;
			// 
			// _btnClose
			// 
			_btnClose.AutoSize = true;
			_btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			_btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			_btnClose.Location = new System.Drawing.Point(528, 8);
			_btnClose.Margin = new System.Windows.Forms.Padding(0);
			_btnClose.Name = "_btnClose";
			_btnClose.Padding = new System.Windows.Forms.Padding(4);
			_btnClose.Size = new System.Drawing.Size(53, 31);
			_btnClose.TabIndex = 0;
			_btnClose.Text = "&Close";
			_btnClose.UseVisualStyleBackColor = true;
			_btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(0, 0);
			label1.Margin = new System.Windows.Forms.Padding(0);
			label1.Name = "label1";
			label1.Padding = new System.Windows.Forms.Padding(64, 16, 64, 16);
			label1.Size = new System.Drawing.Size(567, 149);
			label1.TabIndex = 0;
			label1.Text = resources.GetString("label1.Text");
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.flowLayoutPanel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(589, 77);
			this.panel2.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 77);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(589, 0);
			this.panel3.TabIndex = 3;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel3.Controls.Add(label3);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(589, 77);
			this.flowLayoutPanel3.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(589, 136);
			this.panel1.TabIndex = 5;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(label1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 149);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// DataHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 260);
			this.Controls.Add(this.panel1);
			this.Controls.Add(flowLayoutPanel2);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "DataHelp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "What do these data mean?";
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}