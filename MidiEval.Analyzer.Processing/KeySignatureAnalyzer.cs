using MidiEval.Analyzer.Songs;
using Sanford.Multimedia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MidiEval.Analyzer.Processing {

	public class KeySignatureAnalyzer {
		private static readonly KeySignatureAnalyzer _instance = new KeySignatureAnalyzer();

		public static KeySignatureAnalyzer Instance {
			get { return _instance; }
		}

		private bool IsMinorKey(Key key) {
			return (int) key <= 14;
		}

		private float GetCorrelationCoefficient(PointF[] data) {
			float avgX = data.Average(f => f.X), avgY = data.Average(f => f.Y);
			return (float)
				(
					data.Sum(f => (f.X - avgX) * (f.Y - avgY))
					/ data.Sum(f => Math.Pow(f.X - avgX, 2)) * data.Sum(f => Math.Pow(f.Y - avgY, 2))
				);
		}

		public Key Analyze(Song song, KeyFindingProfile profile = KeyFindingProfile.Simple) {
			var keys = Enum.GetValues(typeof(Key));
			var coefficients = new Dictionary<Key, float>();
			var points = keys
				.Cast<Key>()
				.ToDictionary(key => key, key => new PointF[12]);
			float[] highestCoefficient = { 0F };
			var mostLikelyKey = Key.CMajor;

			foreach(var key in keys.Cast<Key>()) {
				for(var i = 0; i < 12; i++)
					points[key][i] =
						new PointF(ProfileDictionary.Weights[profile][this.IsMinorKey(key) ? 1 : 0, i], 0);

				foreach(var note in song.GetAllNotes())
					points[key][note.Pitch.MidiPitch % 12].Y++;

				coefficients.Add(key, this.GetCorrelationCoefficient(points[key]));
			}

			foreach(var coefficient in coefficients
				.Where(coefficient => coefficient.Value > highestCoefficient[0])) {
				highestCoefficient[0] = coefficient.Value;
				mostLikelyKey = coefficient.Key;
			}

			return mostLikelyKey;
		}
	}
}