using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Injector.Common.IEntity;
using Injector.Common.IRepository;
using Injector.Data.ADOModel;

namespace Injector.Data.DataLayer
{
    internal class RepositoryA : AContainer, IRepositoryA
    {
        public IEntityA ReadEntityById(int IdA)
        {
            EntityA entityA = GetContainer().EntitiesA.Single(item => item.Id.Equals(IdA));
            return entityA;
        }

        public IEntityA ReadEntityByName(string name)
        {
            EntityA entityA = GetContainer().EntitiesA.Single(item => item.Name.Equals(name));
            return entityA;
        }

        public void CreateEntity(IEntityA entityA)
        {
            GetContainer().EntitiesA.Add(MappingEntityA(entityA));
            Commit();
        }

        public void UpdateEntity(IEntityA entityA)
        {
            GetContainer().EntitiesA.AddOrUpdate(MappingEntityA(entityA));
            Commit();
        }

        public void DeleteEntity(IEntityA entityA)
        {
            GetContainer().EntitiesA.Remove(MappingEntityA(entityA));
            Commit();
        }

        public void Commit()
        {
            GetContainer().SaveChanges();
        }

        public string ToStringRepository()
        {
            return "Welcome in DataRepository!";
        }
         
        public IEntityA GetConcreteEntityA()
        {
            return new EntityA();
        }

        private EntityA MappingEntityA(IEntityA entityA)
        {
            if (GetContainer().Entry(entityA).State != EntityState.Detached)
            {
                return new EntityA
                {
                    Id = entityA.Id,
                    Name = entityA.Name,
                    Surname = entityA.Surname,
                };
            }
            return entityA as EntityA;
        }
    }
}
