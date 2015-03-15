﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="MonthNameRecord.cs" company="WheelMUD Development Team">
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
    /// Represents a single MonthName row in the MonthName table.
    ///</summary>
    [Alias("MonthNames")]
	public partial class MonthNameRecord 
	{
        [AutoIncrement]
        public virtual long ID { get; set; }
        public virtual string MonthName { get; set; }
	}
}

