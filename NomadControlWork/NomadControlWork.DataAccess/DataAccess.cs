namespace NomadControlWork.DataAccess
{
    using NomadControlWork.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class DataAccess : DbContext
    {
        public DataAccess()
            : base("name=DataAccess")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Print> Prints { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Delivery> Delivers { get; set; }
    }

  
}