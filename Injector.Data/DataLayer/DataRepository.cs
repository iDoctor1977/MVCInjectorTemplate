using System.Data.Entity.Migrations;
using System.Linq;
using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IRepository;
using Injector.Data.ADOModel;

namespace Injector.Data.DataLayer
{
    internal class DataRepository : AContainer, IDataRepository
    {
        public void Commit()
        {
            GetContainer().SaveChanges();
        }

        public IDataEntity GetEntity(int id)
        {
            return GetContainer().DataEntities.Single(entity => entity.Id.Equals(id));
        }

        public void AddEntity(IDataEntity entity)
        {
            GetContainer().DataEntities.Add(entity as DataEntity);
            Commit();
        }

        public void EditEntity(IDataEntity entity)
        {
            GetContainer().DataEntities.AddOrUpdate(entity as DataEntity);
            Commit();
        }

        public void DeleteEntity(IDataEntity entity)
        {
            GetContainer().DataEntities.Remove(entity as DataEntity);
            Commit();
        }

        public string ToStringRepository()
        {
            return "Welcome in DataRepository!";
        }

        public IDataEntity ConvertToDataEntity(IDataModel model)
        {
            return new DataEntity
            {
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname
            };
        }
    }
}
