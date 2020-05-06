///////////////////////////////////////////////////////////////////////////////
//
// <copyright file="$filename" company="AUP Lda.">
// (c) AUP Lda.
// </copyright>
//
///////////////////////////////////////////////////////////////////////////////

namespace Sharp7
{
	// Order Code + Version
	public struct S7OrderCode
	{
		#region Public Fields

		public string Code; // such as "6ES7 151-8AB01-0AB0"
		public byte V1;     // Version 1st digit
		public byte V2;     // Version 2nd digit
		public byte V3;

		#endregion Public Fields

		// Version 3th digit
	};
}
