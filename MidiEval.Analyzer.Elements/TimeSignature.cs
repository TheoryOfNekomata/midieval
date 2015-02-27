using Sanford.Multimedia.Timers;
using System;

namespace MidiEval.Analyzer.Elements {

	public struct TimeSignature {

		public int Numerator { get; set; }

		public int Denominator { get; set; }

		public TimeSignature(int numerator, int denominator)
			: this() {
			this.Numerator = numerator;
			this.Denominator = denominator;
		}

		public override int GetHashCode() {
			return base.GetHashCode();
		}

		public override bool Equals(object obj) {
			TimeSignature timeSignature;
			try {
				timeSignature = (TimeSignature) obj;
			} catch(Exception) {
				return false;
			}
			return timeSignature.Numerator == this.Numerator
				&& timeSignature.Denominator == this.Denominator;
		}

		public override string ToString() {
			return string.Format("{0}/{1}", this.Numerator, this.Denominator);
		}
	}
}