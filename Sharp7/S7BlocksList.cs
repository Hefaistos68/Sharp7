///////////////////////////////////////////////////////////////////////////////
//
// <copyright file="$filename" company="AUP Lda.">
// (c) AUP Lda.
// </copyright>
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;

namespace Sharp7
{
	// Block List
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct S7BlocksList
	{
		public Int32 OBCount;
		public Int32 FBCount;
		public Int32 FCCount;
		public Int32 SFBCount;
		public Int32 SFCCount;
		public Int32 DBCount;
		public Int32 SDBCount;
	};
}
