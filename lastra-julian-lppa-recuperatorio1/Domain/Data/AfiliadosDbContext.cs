using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain.Data
{
    public class AfiliadosDbContext : DbContext
    {
        public AfiliadosDbContext()
        : base("DefaultConnection") 
        {
        }
        public DbSet<Afiliados> Afiliados{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}