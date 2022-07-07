using IstanbulUniKendo.DAL.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IstanbulUniKendo.DAL.Context
{
    public partial class IUKendoContext : DbContext
    {
        public IUKendoContext()
            : base("name=IUKendoContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public DbSet<Student> Students { get; set; }    
        public DbSet<User> Users { get; set; }    
    }
}
