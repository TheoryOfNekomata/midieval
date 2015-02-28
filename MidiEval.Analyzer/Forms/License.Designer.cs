namespace MidiEval.Analyzer.Forms {
	partial class License {
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
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
			System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			this._btnClose = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			label1 = new System.Windows.Forms.Label();
			flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(0, 0);
			label1.Margin = new System.Windows.Forms.Padding(0);
			label1.Name = "label1";
			label1.Padding = new System.Windows.Forms.Padding(64, 16, 64, 16);
			label1.Size = new System.Drawing.Size(586, 253);
			label1.TabIndex = 0;
			label1.Text = resources.GetString("label1.Text");
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.AutoSize = true;
			flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			flowLayoutPanel2.Controls.Add(this._btnClose);
			flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			flowLayoutPanel2.Location = new System.Drawing.Point(0, 413);
			flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
			flowLayoutPanel2.Size = new System.Drawing.Size(604, 47);
			flowLayoutPanel2.TabIndex = 3;
			// 
			// _btnClose
			// 
			this._btnClose.AutoSize = true;
			this._btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btnClose.Location = new System.Drawing.Point(543, 8);
			this._btnClose.Margin = new System.Windows.Forms.Padding(0);
			this._btnClose.Name = "_btnClose";
			this._btnClose.Padding = new System.Windows.Forms.Padding(4);
			this._btnClose.Size = new System.Drawing.Size(53, 31);
			this._btnClose.TabIndex = 0;
			this._btnClose.Text = "&Close";
			this._btnClose.UseVisualStyleBackColor = true;
			this._btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// label2
			// 
			label2.AutoEllipsis = true;
			label2.Dock = System.Windows.Forms.DockStyle.Top;
			label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label2.Location = new System.Drawing.Point(0, 0);
			label2.Margin = new System.Windows.Forms.Padding(0);
			label2.Name = "label2";
			label2.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
			label2.Size = new System.Drawing.Size(604, 65);
			label2.TabIndex = 1;
			label2.Text = "Copyright © 2015 Allan Crisostomo, Jonathan Doydora, Alvin Bragais, Kennedy Legar" +
    "te\r\n";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			label3.Size = new System.Drawing.Size(519, 77);
			label3.TabIndex = 2;
			label3.Text = "The MIT License for MIDIEval";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.flowLayoutPanel1.Size = new System.Drawing.Size(587, 253);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 187);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(604, 226);
			this.panel1.TabIndex = 4;
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
			this.panel2.Size = new System.Drawing.Size(604, 187);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.AutoSize = true;
			this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel3.Controls.Add(label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 77);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(604, 65);
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
			this.flowLayoutPanel3.Size = new System.Drawing.Size(604, 77);
			this.flowLayoutPanel3.TabIndex = 3;
			// 
			// License
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(604, 460);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(flowLayoutPanel2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 400);
			this.Name = "License";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "License";
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button _btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Panel panel3;
	}
}