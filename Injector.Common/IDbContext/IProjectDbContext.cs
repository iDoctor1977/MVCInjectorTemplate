using System.Data.Entity;
using Injector.Common.DTOModel;

namespace Injector.Common.IDbContext
{
    public interface IProjectDbContext
    {
        DbSet<EntityA> EntitiesA { get; set; }
        DbSet<EntityB> EntitiesB { get; set; }
    }
}