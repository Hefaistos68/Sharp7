///////////////////////////////////////////////////////////////////////////////
//
// <copyright file="$filename" company="AUP Lda.">
// (c) AUP Lda.
// </copyright>
//
///////////////////////////////////////////////////////////////////////////////

using System;

namespace Sharp7
{
	public struct S7DataItem
	{
		#region Public Fields

		public int Amount;
		public int Area;
		public int DBNumber;
		public IntPtr pData;
		public int Result;
		public int Start;
		public int WordLen;

		#endregion Public Fields
	}
}
