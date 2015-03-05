using MidiEval.Analyzer.Elements;
using MidiEval.Analyzer.Processing.Collections;
using MidiEval.Analyzer.Songs;
using System.Collections.Generic;
using System.Linq;

namespace MidiEval.Analyzer.Processing {

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
		/// Gets the contiguous notes from a <see cref="Channel"/> in a given time range.
		/// </summary>
		/// <param name="start">The start.</param>
		/// <param name="end">The end.</param>
		/// <param name="channel">The channel.</param>
		/// <returns>Array of <see cref="Note"/>s (a phrase)</returns>
		private NoteGroup GetContiguousNotes(int start, int end, Channel channel) {
			while(true) {
				var notes = new NoteGroup(channel.GetNotesInTimeRange(start, end));
				var latestNote = notes.LatestNote;
				var earliestNote = notes.EarliestNote;
				if(latestNote == null || earliestNote == null)
					return null;
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
		private NoteGroup GetContiguousNotes(int start, int end, Song song) {
			while(true) {
				var notes = new NoteGroup(song.GetNotesInTimeRange(start, end));
				var latestNote = notes.LatestNote;
				var earliestNote = notes.EarliestNote;
				if(latestNote == null || earliestNote == null)
					return null;
				if(latestNote.NoteOff <= end && earliestNote.NoteOn >= start)
					return notes;
				start = earliestNote.NoteOn;
				end = latestNote.NoteOff;
			}
		}

		/// <summary>
		/// Groups notes in a song.
		/// </summary>
		/// <param name="song">The song.</param>
		/// <returns>Array of <see cref="Note"/> arrays.</returns>
		public NoteGroup[] GroupNotes(Song song) {
			var noteGroups = new List<NoteGroup>();
			var allNotes = new NoteGroup(song.GetAllNotes());

			if(allNotes.Notes.Count <= 0)
				return noteGroups.ToArray();

			var firstNote = allNotes.EarliestNote;

			var notesRemaining = allNotes.Notes.Count;

			var start = firstNote.NoteOn;
			var end = firstNote.NoteOff;
			while(notesRemaining > 0) {
				var noteGroup = this.GetContiguousNotes(start, end, song);
				if(noteGroup != null && noteGroup.Notes.Count > 0) {
					noteGroups.Add(noteGroup);
					notesRemaining -= noteGroup.Notes.Count;
					start = noteGroup.LatestNote.NoteOff + 1;
				} else {
					start++;
				}
				end = start + 1;
			}

			return noteGroups.ToArray();
		}
	}
}