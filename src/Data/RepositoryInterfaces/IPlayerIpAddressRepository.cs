﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="IPlayerIpAddressRepository.cs" company="WheelMUD Development Team">
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
    /// Repository interface for the PlayerIpAddress entity.
    ///</summary>
    public interface IPlayerIpAddressRepository
    {        
        void Add(PlayerIpAddressRecord playeripaddress);
        void Update(PlayerIpAddressRecord playeripaddress);
        void Remove(PlayerIpAddressRecord playeripaddress);
        PlayerIpAddressRecord GetById(long playeripaddressId);		
        PlayerIpAddressRecord GetByName(string name);
        ICollection<PlayerIpAddressRecord> FetchAll();
    }
}