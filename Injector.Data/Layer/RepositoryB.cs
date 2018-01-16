using System;
using Injector.Common.DTOModel;
using Injector.Common.IEntity;
using Injector.Common.IRepository;
using Injector.Data.ADOModel;

namespace Injector.Data.Layer
{
    public class RepositoryB : ARBase, IRepositoryB
    {
        public void Commit()
        {
            GetIstanceOfDataDbContext.SaveChanges();
        }

        public ModelB ReadEntityById(int id)
        {
            EntityB entityB = GetIstanceOfDataDbContext.EntitiesB.Single(entity => entity.Id.Equals(id));
            return entityB;
        }

        public ModelB ReadEntityByUsername(string username)
        {
            EntityB entityB = GetIstanceOfDataDbContext.EntitiesB.Single(item => item.Username.Equals(username));
            return entityB;
        }

        public Guid CreateEntity(ModelB modelB)
        {
            GetIstanceOfDataDbContext.EntitiesB.Add(MappingEntityB(modelB));
            Commit();
        }

        public int UpdateEntity(ModelB modelB)
        {
            GetIstanceOfDataDbContext.EntitiesB.AddOrUpdate(MappingEntityB(modelB));
            Commit();
        }

        public int DeleteEntity(ModelB entityB)
        {
            GetIstanceOfDataDbContext.EntitiesB.Remove(MappingEntityB(entityB));
            Commit();
        }

        public string ToStringRepository()
        {
            return "Welcome in DataRepository!";
        }

        public IEntityB GetConcreteEntityB()
        {
            return GetIstanceOfEntityB;
        }

        private EntityB MappingEntityB(IEntityB entityB)
        {
            if (GetIstanceOfDataDbContext.Entry(entityB).State != EntityState.Detached)
            {
                EntityB concreteEntityB = GetIstanceOfEntityB;
                concreteEntityB.Id = entityB.Id;
                concreteEntityB.Username = entityB.Username;
                concreteEntityB.Email = entityB.Email;
                return concreteEntityB;
            }
            return entityB as EntityB;
        }
    }
}
