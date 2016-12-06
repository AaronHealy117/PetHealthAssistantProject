using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetHealthAssistantProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PetHealthAssistantProject.DAL
{

    public class PetContext : DbContext
    {

        public PetContext() : base("PetContext")
        {
        }

        public DbSet<Pet> Pet { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Vet> Vet { get; set; }
        public DbSet<Walks> Walks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}