using KontaktService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace KontaktService.DAL
{
    public class ImenikContext : DbContext
    {
        public ImenikContext() : base("ImenikContext")
        {
        }

        public DbSet<Kontakt> Kontakti { get; set; }
        public DbSet<Telefon> Telefoni { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}