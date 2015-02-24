using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using MidiEval.Core.Elements;

namespace MidiEval.Core {
	class MidiSegmenter {
		private static MidiSegmenter _instance = new MidiSegmenter();

		public static MidiSegmenter Instance {
			get { return _instance; }
		}

		/*
		private Note[] GetNotesInTimeRange(long _start, long _end, MidiFileStreamReader _reader) {
			
			var _isRead = true;
			var _offset = 0;
			while(_isRead) {
				try {
					_isRead = _reader.ReadNextEvent();
				} catch(Exception _ex) {
					System.Windows.Forms.MessageBox.Show(_ex.Message);
				}
				var _debug = "" + _offset + "-" + (_offset + 3) + ": ";
				var _firstEvent = BitConverter.GetBytes(_reader.MidiEvent);
				//if(BitConverter.IsLittleEndian)
					//Array.Reverse(_firstEvent);
				foreach(var b in _firstEvent) {
					_debug += " " + Convert.ToString(b, 2).PadLeft(8, '0');
				}
				foreach(var b in _firstEvent) {
					_debug += "" + (b >= 32 && b <= 126 ? Convert.ToChar(b) : '.');
				}
				System.Windows.Forms.MessageBox.Show("" + _debug.Trim());
				_offset += 4;
			}
			return null;
		}
		 */
	}
}
