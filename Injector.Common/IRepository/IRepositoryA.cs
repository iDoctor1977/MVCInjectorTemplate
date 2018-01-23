using System;
using System.Collections.Generic;
using Injector.Common.DTOModel;

namespace Injector.Common.IRepository
{
    public interface IRepositoryA
    {
        Guid CreateEntity(ModelA modelA);
        bool UpdateEntity(ModelA modelA);
        ModelA ReadEntityById(Guid id);
        ModelA ReadEntityByName(string name);
        IEnumerable<ModelA> ReadEntities();
        bool DeleteEntity(ModelA modelA);
    }
}