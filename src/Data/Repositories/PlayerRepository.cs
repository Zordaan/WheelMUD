﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="PlayerRepository.cs" company="WheelMUD Development Team">
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
    /// Repository for the Players table.
    ///</summary>
    public partial class PlayerRepository : IPlayerRepository
    {		
        #region IPlayerRepository Members

        public void Add(PlayerRecord player)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Save(player);
                    transaction.Commit();
                }
        }

        public void Update(PlayerRecord player)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Update(player);
                    transaction.Commit();
                }
        }

        public void Remove(PlayerRecord player)
        {
            using (IDbCommand session = Helpers.OpenSession())
                using (IDbTransaction transaction = session.Connection.BeginTransaction())
                {
                    session.Connection.Delete(player);
                    transaction.Commit();
                }
        }
        
        public PlayerRecord GetById(long playerId)
        {
            using (IDbCommand session = Helpers.OpenSession())
                return session.Connection.SingleWhere<PlayerRecord>("ID = {0}", playerId);
        }		

        public PlayerRecord GetByName(string name)
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.SingleWhere<PlayerRecord>("Name = {0}", name);
            }
        }

        public ICollection<PlayerRecord> FetchAll()
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.Select<PlayerRecord>();
            }
        }

        #endregion
    }
}