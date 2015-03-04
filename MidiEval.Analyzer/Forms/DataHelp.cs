using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MidiEval.Analyzer.Forms {

	public partial class DataHelp : Form {

		public DataHelp() {
			InitializeComponent();
		}

		private void BtnClose_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}