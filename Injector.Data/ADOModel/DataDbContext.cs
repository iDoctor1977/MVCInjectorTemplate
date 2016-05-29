using System.Data.Entity;

namespace Injector.Data.ADOModel
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() : base("name=InjectorContainer") { }

        public DbSet<EntityA> EntitiesA { get; set; }
        public DbSet<EntityB> EntitiesB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityA>().ToTable("EntitiesA");
            modelBuilder.Entity<EntityB>().ToTable("EntitiesB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
