using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Sanford.Multimedia.Midi;

using MidiEval.Core;

namespace MidiEval {
	static class Program {
		static BinaryReader _reader;

		public static void Analyze(string _fileName) {

			var _sequence = new Sequence(_fileName);

			foreach(var _track in _sequence) {
				for(var i = 0; i < _track.Count; i++) {
					System.Windows.Forms.MessageBox.Show("#" + i + ": " + _track.GetMidiEvent(i).DeltaTicks);
				}
			}
			
			//MidiSegmenter.Instance.GetPhrases(_stream);
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
