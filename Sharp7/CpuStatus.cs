﻿///////////////////////////////////////////////////////////////////////////////
//
// <copyright file="$filename" company="AUP Lda.">
// (c) AUP Lda.
// </copyright>
//
///////////////////////////////////////////////////////////////////////////////

namespace Sharp7
{
	/// <summary>
	/// PLC CPU Status
	/// </summary>
	public enum CpuStatus
	{
		Unknown = 0x00,
		Running = 0x08,
		Stopped = 0x04
	}
}