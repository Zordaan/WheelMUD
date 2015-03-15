﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="IMxpRepository.cs" company="WheelMUD Development Team">
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
    /// Repository interface for the Mxp entity.
    ///</summary>
    public interface IMxpRepository
    {        
        void Add(MxpRecord mxp);
        void Update(MxpRecord mxp);
        void Remove(MxpRecord mxp);
        MxpRecord GetById(long mxpId);		
        MxpRecord GetByName(string name);
        ICollection<MxpRecord> FetchAll();
    }
}