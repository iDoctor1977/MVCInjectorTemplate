using System;
using System.Collections.Generic;
using Injector.Common.DTOModel;
using Injector.Common.IEntity;

namespace Injector.Common.IRepository
{
    public interface IRepositoryB
    {
        Guid CreateEntity(ModelB modelB);
        int UpdateEntity(ModelB modelB);
        ModelB ReadEntityById(Guid id);
        ModelB ReadEntityByUsername(string username);
        IEnumerable<ModelB> ReadEntities();
        int DeleteEntity(ModelB entityB);
    }
}