using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MyArmoryLibrary.Models;

namespace MyArmoryLibrary
{
    public class ArmoryDatabase : DbContext
    {
        #region Methods

        public ArmoryDatabase(string connectionName) : base(connectionName)
        {

        }

        #endregion

        #region Properties

        public DbSet<Character> Characters { get; set; }

        #endregion
    }
}
