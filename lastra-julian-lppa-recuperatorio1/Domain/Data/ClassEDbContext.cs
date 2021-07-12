using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain.Data
{
    public class ClassEDbContext : DbContext
    {
        public ClassEDbContext()
        : base("DefaultConnection") 
        {
        }
        public DbSet<ClassE> ClassEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}