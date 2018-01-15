using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Injector.Common.IEntity;
using Injector.Common.IRepository;
using Injector.Data.ADOModel;

namespace Injector.Data.Layer
{
    public class RepositoryA : ABaseRepository, IRepositoryA
    {
        public IEntityA ReadEntityById(int IdA)
        {
            EntityA entityA = GetIstanceOfDataDbContext.EntitiesA.Single(item => item.Id.Equals(IdA));
            return entityA;
        }

        public IEntityA ReadEntityByName(string name)
        {
            EntityA entityA = GetIstanceOfDataDbContext.EntitiesA.Single(item => item.Name.Equals(name));
            return entityA;
        }

        public void CreateEntity(IEntityA entityA)
        {
            GetIstanceOfDataDbContext.EntitiesA.Add(MappingEntityA(entityA));
            Commit();
        }

        public void UpdateEntity(IEntityA entityA)
        {
            GetIstanceOfDataDbContext.EntitiesA.AddOrUpdate(MappingEntityA(entityA));
            Commit();
        }

        public void DeleteEntity(IEntityA entityA)
        {
            GetIstanceOfDataDbContext.EntitiesA.Remove(MappingEntityA(entityA));
            Commit();
        }

        public void Commit()
        {
            GetIstanceOfDataDbContext.SaveChanges();
        }

        public string ToStringRepository()
        {
            return "Welcome in DataRepository!";
        }

        public IEntityA GetConcreteEntityA()
        {
            return GetIstanceOfEntityA;
        }
         
        private EntityA MappingEntityA(IEntityA entityA)
        {
            if (GetIstanceOfDataDbContext.Entry(entityA).State != EntityState.Detached)
            {
                EntityA concreteEntityA = GetIstanceOfEntityA;
                concreteEntityA.Id = entityA.Id;
                concreteEntityA.Name = entityA.Name;
                concreteEntityA.Surname = entityA.Surname;
                return concreteEntityA;
            }
            return entityA as EntityA;
        }
    }
}
