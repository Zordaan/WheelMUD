﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="TypoRecord.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by EntityRecord.cst on 7/7/2012 4:24:10 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
	using System;

    using ServiceStack.DataAnnotations;
	
    ///<summary>
    /// Represents a single Typo row in the Typo table.
    ///</summary>
    [Alias("Typos")]
	public partial class TypoRecord 
	{
        [AutoIncrement]
        public virtual long ID { get; set; }
        public virtual string Note { get; set; }
        public virtual long SubmittedByPlayerID { get; set; }
        public virtual long RoomID { get; set; }
        public virtual string SubmittedDateTime { get; set; }
        public virtual bool Resolved { get; set; }
        public virtual long ResolvedByPlayerID { get; set; }
        public virtual string ResolvedDateTime { get; set; }
	}
}

