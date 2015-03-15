﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="DayNameRecord.cs" company="WheelMUD Development Team">
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
    /// Represents a single DayName row in the DayName table.
    ///</summary>
    [Alias("DayNames")]
	public partial class DayNameRecord 
	{
        [AutoIncrement]
        public virtual long ID { get; set; }
        public virtual string DayName { get; set; }
	}
}

