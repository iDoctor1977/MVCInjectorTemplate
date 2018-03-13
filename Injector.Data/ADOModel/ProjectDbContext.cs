using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Injector.Common.DTOEntity;
using Injector.Common.IDbContext;
using Injector.Common.IEntity;

namespace Injector.Data.ADOModel
{
    public class ProjectDbContext : DbContext, IProjectDbContext
    {
        #region CONSTRUCTOR

        public ProjectDbContext() : base("name=ProjectDbContext") { }

        public ProjectDbContext(string connectionStringName) : base(connectionStringName) { }

        #endregion

        public virtual DbSet<EntityA> EntitiesA { get; set; }
        public virtual DbSet<EntityB> EntitiesB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Code-First will create the database tables with the name of DbSet properties
            // in the context class - Students and Standards in this case. You can override
            // this convention and can give a different table name than the DbSet properties
            //modelBuilder.Entity<EntityA>().ToTable("EntitiesA");
            //modelBuilder.Entity<EntityB>().ToTable("EntitiesB");
            base.OnModelCreating(modelBuilder);
        }

        #region SOFT DELETE METHOD

        public override int SaveChanges()
        {
            foreach (DbEntityEntry entry in ChangeTracker.Entries<ISoftDelete>().Where(es => es.State == EntityState.Deleted))
            {
                ((ISoftDelete)entry.Entity).IsDeleted = true;
                ((ISoftDelete)entry.Entity).DeleteDate = DateTime.Now;

                entry.State = EntityState.Modified;
            }

            return base.SaveChanges();
        }

        #endregion
    }

    public class DebugInitializer : DropCreateDatabaseAlways<ProjectDbContext>
    {
        protected override void Seed(ProjectDbContext context)
        {
            context.EntitiesA.Add(new EntityA { Name = "Gianni", Surname = "Fantoni"});
            base.Seed(context);
        }
    }

    public class RunInitializer : CreateDatabaseIfNotExists<ProjectDbContext>
    {
        protected override void Seed(ProjectDbContext context)
        {
            context.EntitiesA.Add(new EntityA { Name = "Gianni", Surname = "Fantoni"});
            base.Seed(context);
        }
    }
}
