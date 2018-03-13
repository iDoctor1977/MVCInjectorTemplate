using System;
using System.Collections.Generic;
using Injector.Common.DTOEntity;

namespace Injector.Common.IRepository
{
    public interface IRepositoryA
    {
        Guid CreateEntity(EntityA entityA);
        bool UpdateEntity(EntityA entityA);
        EntityA ReadEntityById(Guid id);
        EntityA ReadEntityByName(string name);
        IEnumerable<EntityA> ReadEntities();
        bool DeleteEntity(EntityA entityA);
    }
}