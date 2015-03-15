﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="HelpTopicRecord.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by EntityRecord.cst on 7/7/2012 4:24:09 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
	using System;

    using ServiceStack.DataAnnotations;
	
    ///<summary>
    /// Represents a single HelpTopic row in the HelpTopic table.
    ///</summary>
    [Alias("HelpTopics")]
	public partial class HelpTopicRecord 
	{
        [AutoIncrement]
        public virtual long ID { get; set; }
        public virtual string HelpTopic { get; set; }
        public virtual string Usage { get; set; }
        public virtual string Description { get; set; }
        public virtual string Example { get; set; }
        public virtual string SeeAlso { get; set; }
        public virtual string ViewTemplate { get; set; }
	}
}

