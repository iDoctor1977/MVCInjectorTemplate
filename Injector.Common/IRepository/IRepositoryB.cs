using System;
using System.Collections.Generic;
using Injector.Common.DTOModel;

namespace Injector.Common.IRepository
{
    public interface IRepositoryB
    {
        Guid CreateEntity(ModelB modelB);
        bool UpdateEntity(ModelB modelB);
        ModelB ReadEntityById(Guid id);
        ModelB ReadEntityByUsername(string username);
        IEnumerable<ModelB> ReadEntities();
        bool DeleteEntity(ModelB entityB);
    }
}