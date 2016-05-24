using System.Data.Entity.Migrations;
using System.Linq;
using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IRepository;
using Injector.Data.ADOModel;

namespace Injector.Data.DataLayer
{
    internal class RepositoryA : AContainer, IRepositoryA
    {
        public void Commit()
        {
            GetContainer().SaveChanges();
        }

        public IEntityA GetEntity(int id)
        {
            return GetContainer().EntitiesA.Single(entity => entity.Id.Equals(id));
        }

        public void AddEntity(IEntityA entity)
        {
            GetContainer().EntitiesA.Add(entity as EntityA);
            Commit();
        }

        public void EditEntity(IEntityA entity)
        {
            GetContainer().EntitiesA.AddOrUpdate(entity as EntityA);
            Commit();
        }

        public void DeleteEntity(IEntityA entity)
        {
            GetContainer().EntitiesA.Remove(entity as EntityA);
            Commit();
        }

        public string ToStringRepository()
        {
            return "Welcome in DataRepository!";
        }

        public IEntityA ConvertToDataEntity(IModelA model)
        {
            return new EntityA
            {
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname
            };
        }
    }
}
