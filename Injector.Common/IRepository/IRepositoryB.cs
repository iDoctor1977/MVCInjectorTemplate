using System;
using System.Collections.Generic;
using Injector.Common.DTOEntity;

namespace Injector.Common.IRepository
{
    public interface IRepositoryB
    {
        Guid CreateEntity(EntityB entityB);
        bool UpdateEntity(EntityB entityB);
        EntityB ReadEntityById(Guid id);
        EntityB ReadEntityByUsername(string username);
        IEnumerable<EntityB> ReadEntities();
        bool DeleteEntity(EntityB entityB);
    }
}