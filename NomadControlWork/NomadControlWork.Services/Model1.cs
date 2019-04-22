namespace NomadControlWork.Services
{
    using NomadControlWork.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }
    
        public List<User> Users { get; set; }
        public List<Journal> Journal { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}