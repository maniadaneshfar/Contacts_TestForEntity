
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using Contacts.Entity.Model;
using System.Text;


namespace Contacts.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {

        }




        public DbSet<Contacts.Entity.Model.Contacts> MyContact { get; set; } 




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ContactEF_DB;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
