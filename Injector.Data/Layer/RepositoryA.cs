using System;
using System.Data.Entity.Infrastructure;
using System.Reflection;
using Injector.Common.DTOModel;
using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IRepository;
using Injector.Common.IStore;
using Injector.Data.ADOModel;

namespace Injector.Data.Layer
{
    public class RepositoryA : ARBase, IRepositoryA
    {
        #region CONSTRUCTOR

        public RepositoryA()
        {
        }

        public RepositoryA(IDataStore dataStore) : base(dataStore)
        {
        }

        #endregion

        public Guid CreateEntity(ModelA modelA)
        {
            try
            {
                EntityA entityA = ARBaseDataStore.NewConverterA.ConvertModelToEntity(modelA) as EntityA;

                Flat flat = ARBaseDataStore.NewConvertFlat.ConvertModelToEntity(mlFlat) as Flat;

                if (flat != null)
                {
                    flat.FlatId = Guid.NewGuid();
                    flat.RecordState = CRecordState.SAVED;
                    flat.DateOfSaved = DateTime.Now;
                    ARBaseDbContext().Flats.Add(flat);
                    Commit();

                    return flat.FlatId;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Guid.Empty;
        }

        public int UpdateEntity(ModelA entityA)
        {
            throw new System.NotImplementedException();
        }

        ModelA IRepositoryA.ReadEntityById(int id)
        {
            throw new System.NotImplementedException();
        }

        ModelA IRepositoryA.ReadEntityByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteEntity(ModelA entityA)
        {
            throw new System.NotImplementedException();
        }

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

        public IEntityA GetConcreteEntityA()
        {
            return GetIstanceOfEntityA;
        }
    }
}
