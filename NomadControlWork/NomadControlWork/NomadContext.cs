namespace NomadControlWork
{
    using NomadControlWork.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NomadContext : DbContext
    {
        public NomadContext()
            : base("name=NomadContext")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Print> Prints { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }

    }
}