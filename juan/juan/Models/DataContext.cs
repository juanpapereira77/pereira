﻿

namespace juan.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<juan.Models.Clown> Clowns { get; set; }
    }
}