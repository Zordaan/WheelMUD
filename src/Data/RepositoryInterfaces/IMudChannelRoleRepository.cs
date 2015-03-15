﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="IMudChannelRoleRepository.cs" company="WheelMUD Development Team">
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
    /// Repository interface for the MudChannelRole entity.
    ///</summary>
    public interface IMudChannelRoleRepository
    {        
        void Add(MudChannelRoleRecord mudchannelrole);
        void Update(MudChannelRoleRecord mudchannelrole);
        void Remove(MudChannelRoleRecord mudchannelrole);
        MudChannelRoleRecord GetById(long mudchannelroleId);		
        MudChannelRoleRecord GetByName(string name);
        ICollection<MudChannelRoleRecord> FetchAll();
    }
}