using System.Data.Entity;
using Injector.Common.DTOEntity;

namespace Injector.Common.IDbContext
{
    public interface IProjectDbContext
    {
        DbSet<EntityA> EntitiesA { get; set; }
        DbSet<EntityB> EntitiesB { get; set; }
    }
}