﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="IRoomVisualRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by RepositoryInterface.cst on 7/7/2012 4:24:10 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    using System.Collections.Generic;	
    
    ///<summary>
    /// Repository interface for the RoomVisual entity.
    ///</summary>
    public interface IRoomVisualRepository
    {        
        void Add(RoomVisualRecord roomvisual);
        void Update(RoomVisualRecord roomvisual);
        void Remove(RoomVisualRecord roomvisual);
        RoomVisualRecord GetById(long roomvisualId);		
        RoomVisualRecord GetByName(string name);
        ICollection<RoomVisualRecord> FetchAll();
    }
}