using System.Data.Entity;

namespace Injector.Data.ADOModel
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() : base("name=InjectorContainer")
        {
            #if DEBUG
            Database.SetInitializer(new DebugInitializer());
            #endif 
            Database.SetInitializer(new RunInitializer());
        }

        public DbSet<EntityA> EntitiesA { get; set; }
        public DbSet<EntityB> EntitiesB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Code-First will create the database tables with the name of DbSet properties
            // in the context class - Students and Standards in this case. You can override
            // this convention and can give a different table name than the DbSet properties
            //modelBuilder.Entity<EntityA>().ToTable("EntitiesA");
            //modelBuilder.Entity<EntityB>().ToTable("EntitiesB");
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DebugInitializer : DropCreateDatabaseAlways<DataDbContext>
    {
        protected override void Seed(DataDbContext context)
        {
            context.EntitiesA.Add(new EntityA {Name = "Gianni", Surname = "Fantoni"});
            base.Seed(context);
        }
    }

    public class RunInitializer : CreateDatabaseIfNotExists<DataDbContext>
    {
        protected override void Seed(DataDbContext context)
        {
            context.EntitiesA.Add(new EntityA {Name = "Gianni", Surname = "Fantoni"});
            base.Seed(context);
        }
    }
}
