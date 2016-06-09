using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Injector.Common.IEntity;
using Injector.Common.IRepository;
using Injector.Data.ADOModel;

namespace Injector.Data.DataLayer
{
    internal class RepositoryB : AContainer, IRepositoryB
    {
        public void Commit()
        {
            GetContainer().SaveChanges();
        }

        public IEntityB ReadEntityById(int id)
        {
            EntityB entityB = GetContainer().EntitiesB.Single(entity => entity.Id.Equals(id));
            return entityB;
        }

        public IEntityB ReadEntityByUsername(string username)
        {
            EntityB entityB = GetContainer().EntitiesB.Single(item => item.Username.Equals(username));
            return entityB;
        }

        public void CreateEntity(IEntityB entityB)
        {
            GetContainer().EntitiesB.Add(MappingEntityB(entityB));
            Commit();
        }

        public void UpdateEntity(IEntityB entityB)
        {
            GetContainer().EntitiesB.AddOrUpdate(MappingEntityB(entityB));
            Commit();
        }

        public void DeleteEntity(IEntityB entityB)
        {
            GetContainer().EntitiesB.Remove(MappingEntityB(entityB));
            Commit();
        }

        public string ToStringRepository()
        {
            return "Welcome in DataRepository!";
        }

        public IEntityB GetConcreteEntityB()
        {
            return new EntityB();
        }

        private EntityB MappingEntityB(IEntityB entityB)
        {
            if (GetContainer().Entry(entityB).State != EntityState.Detached)
            {
                return new EntityB
                {
                    Id = entityB.Id,
                    Username = entityB.Username,
                    Email = entityB.Email,
                };
            }
            return entityB as EntityB;
        }
    }
}
