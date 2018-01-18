using System;
using Injector.Common.DTOModel;

namespace Injector.Common.IRepository
{
    public interface IRepositoryA
    {
        Guid CreateEntity(ModelA modelA);
        int UpdateEntity(ModelA modelA);
        ModelA ReadEntityById(int id);
        ModelA ReadEntityByName(string name);
        int DeleteEntity(ModelA modelA);
    }
}