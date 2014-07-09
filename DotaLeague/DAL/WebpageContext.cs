using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using DotaLeague.Models;

namespace DotaLeague.DAL
{
    public class WebpageContext : DbContext
    {

        public WebpageContext() : base("WebpageContext")
        {
            
        }

        public DbSet<User> User { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<League> League { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}