﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="PlayerIpAddressRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by Repository.cst on 4/9/2013 4:29:50 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using ServiceStack.OrmLite;
    using WheelMUD.Data.Entities;
    
    ///<summary>
    /// Repository for the PlayerIPAddress table.
    ///</summary>
    public partial class PlayerIpAddressRepository : IPlayerIpAddressRepository
    {		
        #region IPlayerIpAddressRepository Members

        public void Add(PlayerIpAddressRecord playeripaddress)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Save(playeripaddress);
                    transaction.Commit();
                }
        }

        public void Update(PlayerIpAddressRecord playeripaddress)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Update(playeripaddress);
                    transaction.Commit();
                }
        }

        public void Remove(PlayerIpAddressRecord playeripaddress)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Delete(playeripaddress);
                    transaction.Commit();
                }
        }
        
        public PlayerIpAddressRecord GetById(long playeripaddressId)
        {
            using (IDbCommand session = Helpers.OpenSession())
                return session.Connection.SingleWhere<PlayerIpAddressRecord>("ID = {0}", playeripaddressId);
        }		

        public PlayerIpAddressRecord GetByName(string name)
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.SingleWhere<PlayerIpAddressRecord>("Name = {0}", name);
            }
        }

        public ICollection<PlayerIpAddressRecord> FetchAll()
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.Select<PlayerIpAddressRecord>();
            }
        }

        #endregion
    }
}