using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Songs.Input;
using Sanford.Multimedia;
using Sanford.Multimedia.Midi;
using System.Collections.Generic;
using System.Linq;
using Note = MidiEval.Analyzer.Elements.Note;

namespace MidiEval.Analyzer.Songs {

	/// <summary>
	/// A class for a song.
	/// </summary>
	public struct Song {

		/// <summary>
		/// Gets or sets the time signature.
		/// </summary>
		/// <value>
		/// The time signature.
		/// </value>
		public TimeSignature TimeSignature { get; set; }

		/// <summary>
		/// Gets or sets the key signature.
		/// </summary>
		/// <value>
		/// The key signature.
		/// </value>
		public Key KeySignature { get; set; }

		/// <summary>
		/// Gets or sets the tempo.
		/// </summary>
		/// <value>
		/// The tempo.
		/// </value>
		public double Tempo { get; set; }

		/// <summary>
		/// Gets the channels.
		/// </summary>
		/// <value>
		/// The channels.
		/// </value>
		public Elements.Channel[] Channels { get; private set; }

		private void InitializeTracks() {
			this.Channels = new Elements.Channel[16];
			for(var i = 0; i < this.Channels.Length; i++)
				this.Channels[i] = new Elements.Channel();
		}

		private Note[] GetAllNotes() {
			return this.Channels.SelectMany(
				channel => channel.Notes
			).ToArray();
		}

		/// <summary>
		/// Gets the notes in time range.
		/// </summary>
		/// <param name="start">The start.</param>
		/// <param name="end">The end.</param>
		/// <returns>Array of <see cref="Elements.Note"/>s.</returns>
		public Note[] GetNotesInTimeRange(int start, int end) {
			return this.Channels.SelectMany(
				channel => channel.GetNotesInTimeRange(start, end)
			).ToArray();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Song"/> struct.
		/// </summary>
		/// <param name="timeSignature">The time signature.</param>
		/// <param name="keySignature">The key signature.</param>
		/// <param name="tempo">The tempo.</param>
		public Song(TimeSignature timeSignature, Key keySignature, double tempo)
			: this() {
			this.InitializeTracks();
			this.TimeSignature = timeSignature;
			this.KeySignature = keySignature;
			this.Tempo = tempo;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Song"/> struct from a <see cref="Sequence"/>.
		/// </summary>
		/// <param name="sequence">The sequence.</param>
		public Song(Sequence sequence)
			: this() {
			this.InitializeTracks();
			var events = new List<MidiEvent>();
			foreach(var track in sequence)
				for(var i = 0; i < track.Count; i++)
					events.Add(track.GetMidiEvent(i));

			var channelEventParser = new ChannelEventParser(events);
			var metaEventParser = new MetaEventParser(events);

			this.Channels = channelEventParser.Channels;
			this.KeySignature = metaEventParser.KeySignature;
			this.TimeSignature = metaEventParser.TimeSignature;
			this.Tempo = metaEventParser.Tempo;
		}
	}
}