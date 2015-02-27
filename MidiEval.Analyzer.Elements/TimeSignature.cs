using System;

namespace MidiEval.Analyzer.Elements {

	/// <summary>
	/// Time signature, which is used to group notes by bars.
	/// </summary>
	public struct TimeSignature {

		/// <summary>
		/// Gets or sets the time signature's numerator.
		/// </summary>
		/// <value>
		/// The time signature's numerator.
		/// </value>
		public int Numerator { get; set; }

		/// <summary>
		/// Gets or sets the time signature's denominator.
		/// </summary>
		/// <value>
		/// The time signature's denominator.
		/// </value>
		public int Denominator { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="TimeSignature"/> struct.
		/// </summary>
		/// <param name="numerator">The time signature's numerator.</param>
		/// <param name="denominator">The time signature's denominator.</param>
		public TimeSignature(int numerator, int denominator)
			: this() {
			this.Numerator = numerator;
			this.Denominator = denominator;
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>
		/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
		/// </returns>
		public override int GetHashCode() {
			return base.GetHashCode();
		}

		/// <summary>
		/// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
		/// </summary>
		/// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
		/// <returns>
		///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
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

		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override string ToString() {
			return string.Format("{0}/{1}", this.Numerator, this.Denominator);
		}
	}
}