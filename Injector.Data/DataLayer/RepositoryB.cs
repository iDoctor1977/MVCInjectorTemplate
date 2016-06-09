using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Injector.Common.IEntity;
using Injector.Common.IRepository;
using Injector.Data.ADOModel;

namespace Injector.Data.DataLayer
{
    public class RepositoryB : ABaseRepository, IRepositoryB
    {
        public void Commit()
        {
            GetIstanceOfDataDbContext.SaveChanges();
        }

        public IEntityB ReadEntityById(int id)
        {
            EntityB entityB = GetIstanceOfDataDbContext.EntitiesB.Single(entity => entity.Id.Equals(id));
            return entityB;
        }

        public IEntityB ReadEntityByUsername(string username)
        {
            EntityB entityB = GetIstanceOfDataDbContext.EntitiesB.Single(item => item.Username.Equals(username));
            return entityB;
        }

        public void CreateEntity(IEntityB entityB)
        {
            GetIstanceOfDataDbContext.EntitiesB.Add(MappingEntityB(entityB));
            Commit();
        }

        public void UpdateEntity(IEntityB entityB)
        {
            GetIstanceOfDataDbContext.EntitiesB.AddOrUpdate(MappingEntityB(entityB));
            Commit();
        }

        public void DeleteEntity(IEntityB entityB)
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
