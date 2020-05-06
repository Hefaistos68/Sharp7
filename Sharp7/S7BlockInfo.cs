///////////////////////////////////////////////////////////////////////////////
//
// <copyright file="$filename" company="AUP Lda.">
// (c) AUP Lda.
// </copyright>
//
///////////////////////////////////////////////////////////////////////////////

namespace Sharp7
{
	// Managed Block Info
	public struct S7BlockInfo
	{
		#region Public Fields

		public string Author;
		public int BlkFlags;
		public int BlkLang;
		public int BlkNumber;
		public int BlkType;
		public int CheckSum;

		// Chars info
		public string CodeDate;

		public string Family;
		public string Header;
		public string IntfDate;
		public int LoadSize;
		public int LocalData;
		public int MC7Size;  // The real size in bytes
		public int SBBLength;
		public int Version;

		#endregion Public Fields
	};
}
