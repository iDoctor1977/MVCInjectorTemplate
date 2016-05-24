using System.Data.Entity.Migrations;
using System.Linq;
using Injector.Common.IEntity;
using Injector.Common.IModel;
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

        public IEntityB GetEntity(int id)
        {
            return GetContainer().EntitiesB.Single(entity => entity.Id.Equals(id));
        }

        public void AddEntity(IEntityB entity)
        {
            GetContainer().EntitiesB.Add(entity as EntityB);
            Commit();
        }

        public void EditEntity(IEntityB entity)
        {
            GetContainer().EntitiesB.AddOrUpdate(entity as EntityB);
            Commit();
        }

        public void DeleteEntity(IEntityB entity)
        {
            GetContainer().EntitiesB.Remove(entity as EntityB);
            Commit();
        }

        public string ToStringRepository()
        {
            return "Welcome in DataRepository!";
        }

        public IEntityB ConvertToDataEntity(IModelB model)
        {
            return new EntityB
            {
                Id = model.Id,
                Username = model.Username,
                Email = model.Email
            };
        }
    }
}
