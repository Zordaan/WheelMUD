﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="IRoleRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by RepositoryInterface.cst on 7/7/2012 4:24:09 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    using System.Collections.Generic;	
    
    ///<summary>
    /// Repository interface for the Role entity.
    ///</summary>
    public interface IRoleRepository
    {        
        void Add(RoleRecord role);
        void Update(RoleRecord role);
        void Remove(RoleRecord role);
        RoleRecord GetById(long roleId);		
        RoleRecord GetByName(string name);
        ICollection<RoleRecord> FetchAll();
    }
}