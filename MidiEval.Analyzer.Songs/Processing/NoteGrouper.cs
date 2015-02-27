using MidiEval.Analyzer.Elements;
using System.Collections.Generic;
using System.Linq;

namespace MidiEval.Analyzer.Songs.Processing {

	/// <summary>
	/// A class for grouping notes into phrases.
	/// </summary>
	public class NoteGrouper {
		private static readonly NoteGrouper _instance = new NoteGrouper();

		/// <summary>
		/// Gets the instance of the <see cref="NoteGrouper"/> class.
		/// </summary>
		/// <value>
		/// The instance of the <see cref="NoteGrouper"/> class.
		/// </value>
		public static NoteGrouper Instance {
			get { return _instance; }
		}

		/// <summary>
		/// Gets the earliest note among a collection.
		/// </summary>
		/// <param name="notes">A collection of notes.</param>
		/// <returns>The note with the earliest note on.</returns>
		private Note GetEarliestNote(IEnumerable<Note> notes) {
			Note[] earliestNote = { null };
			foreach(var note in notes.Where(
				note => earliestNote[0] == null
					|| note.NoteOn < earliestNote[0].NoteOn
				)
			)
				earliestNote[0] = note;
			return earliestNote[0];
		}

		/// <summary>
		/// Gets the latest note among a collection.
		/// </summary>
		/// <param name="notes">A collection of notes.</param>
		/// <returns>The note with the earliest note on.</returns>
		private Note GetLatestNote(IEnumerable<Note> notes) {
			Note[] latestNote = { null };
			foreach(var note in notes.Where(
				note => latestNote[0] == null
					|| note.NoteOff > latestNote[0].NoteOff
				)
			)
				latestNote[0] = note;
			return latestNote[0];
		}

		/// <summary>
		/// Gets the contiguous notes from a <see cref="Channel"/> in a given time range.
		/// </summary>
		/// <param name="start">The start.</param>
		/// <param name="end">The end.</param>
		/// <param name="channel">The channel.</param>
		/// <returns>Array of <see cref="Note"/>s (a phrase)</returns>
		private Note[] GetContiguousNotes(int start, int end, Channel channel) {
			while(true) {
				var notes = channel.GetNotesInTimeRange(start, end);
				var latestNote = this.GetLatestNote(notes);
				var earliestNote = this.GetEarliestNote(notes);
				if(latestNote.NoteOff <= end && earliestNote.NoteOn >= start)
					return notes;
				start = earliestNote.NoteOn;
				end = latestNote.NoteOff;
			}
		}

		/// <summary>
		/// Gets the contiguous notes from a <see cref="Song"/> in a given time range.
		/// </summary>
		/// <param name="start">The start.</param>
		/// <param name="end">The end.</param>
		/// <param name="song">The song.</param>
		/// <returns>Array of <see cref="Note"/>s (a phrase)</returns>
		private Note[] GetContiguousNotes(int start, int end, Song song) {
			while(true) {
				var notes = song.GetNotesInTimeRange(start, end);
				var latestNote = this.GetLatestNote(notes);
				var earliestNote = this.GetEarliestNote(notes);
				if(latestNote.NoteOff <= end && earliestNote.NoteOn >= start)
					return notes;
				start = earliestNote.NoteOn;
				end = latestNote.NoteOff;
			}
		}

		/// <summary>
		/// Groups notes in a channel.
		/// </summary>
		/// <param name="channel">The channel.</param>
		/// <returns>Array of <see cref="Note"/> arrays.</returns>
		public Note[][] GroupNotes(Channel channel) {
			var noteGroups = new List<Note[]>();
			var noteGroup = new[] { this.GetEarliestNote(channel.Notes.ToArray()) };
			for(var start = this.GetEarliestNote(noteGroup).NoteOn; noteGroup.Length > 0; start = this.GetLatestNote(noteGroup).NoteOff + 1) {
				noteGroup = this.GetContiguousNotes(start, this.GetLatestNote(noteGroup).NoteOff, channel);
				noteGroups.Add(noteGroup);
			}
			return noteGroups.ToArray();
		}
	}
}