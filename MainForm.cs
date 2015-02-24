using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MidiEval {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void BtnBrowse_Click(object _objSender, EventArgs _e) {
			var _sender = (Button) _objSender;
			if(OpenFileDlgInput.ShowDialog() == DialogResult.OK) {
				foreach(var fileName in OpenFileDlgInput.FileNames) {
					if(_sender == BtnBrowse1) {
						ListFiles1.Items.Add(fileName);
					} else {
						ListFiles2.Items.Add(fileName);
					}
				}
			}
		}

		private void BtnAnalyze_Click(object sender, EventArgs e) {
			TabCtrlMain.SelectedTab = TabPgOutput;

			Program.Analyze(ListFiles1.Items[0].SubItems[0].Text);
		}

		private void BtnGoBack_Click(object sender, EventArgs e) {
			TabCtrlMain.SelectedTab = TabPgInput;
		}
	}
}
