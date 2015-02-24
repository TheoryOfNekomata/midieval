using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiEval.Core.Elements {
	/// <summary>
	/// The representation of a MIDI note.
	/// </summary>
	public struct Note {

		#region Fields


		private byte _pitch;

		private ulong _noteOn;

		private ulong _noteOff;


		#endregion

		#region Properties


		/// <summary>
		/// Gets the Pitch of the note.
		/// </summary>
		public byte Pitch {
			get { return _pitch; }
		}

		/// <summary>
		/// Gets the Note On Message of the note by ticks.
		/// </summary>
		public ulong NoteOn {
			get { return _noteOn; }
		}

		/// <summary>
		/// Gets the Note Off Message of the note by ticks.
		/// </summary>
		public ulong NoteOff {
			get { return _noteOff; }
		}

		/// <summary>
		/// Gets the duration of the note.
		/// </summary>
		public ulong Duration {
			get { return _noteOff - _noteOn; }
		}


		#endregion

	}
}
