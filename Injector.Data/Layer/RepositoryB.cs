using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using Injector.Common.DTOModel;
using Injector.Common.IRepository;
using Injector.Common.IStore;
using Injector.Data.ADOModel;

namespace Injector.Data.Layer
{
    public class RepositoryB : ABaseRepository, IRepositoryB
    {
        private static IRepositoryB RepositoryBInstance { get; set; }

        #region CONSTRUCTOR

        private RepositoryB() { }

        private RepositoryB(IDataStore dataStore) : base(dataStore) { }

        #endregion

        #region SINGLETON

        public static IRepositoryB Instance()
        {
            if (RepositoryBInstance == null)
            {
                RepositoryBInstance = new RepositoryB();
            }

            return RepositoryBInstance;
        }

        public static IRepositoryB Instance(IDataStore dataStore)
        {
            if (RepositoryBInstance == null)
            {
                RepositoryBInstance = new RepositoryB(dataStore);
            }

            return RepositoryBInstance;
        }

        #endregion

        public Guid CreateEntity(ModelB modelB)
        {
            try
            {
                EntityB entityB = ConvertBModelToEntity(modelB) as EntityB;

                if (entityB != null)
                {
                    entityB.Id = Guid.NewGuid();
                    Commit();

                    return entityB.Id;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Guid.Empty;
        }

        public int UpdateEntity(ModelB modelB)
        {
            EntityB entityB = ABaseDbContext().EntitiesB.Find(modelB.Id);

            try
            {
                if (entityB != null)
                {
                    entityB.Username = modelB.Username;
                    entityB.Email = modelB.Email;
                    Commit();

                    return 1;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return -1;
        }

        public ModelB ReadEntityById(Guid id)
        {
            try
            {
                EntityB entityB = ABaseDbContext().EntitiesB.Find(id);

                if (entityB != null)
                {
                    return ConvertBEntityToModel(entityB);
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public ModelB ReadEntityByUsername(string username)
        {
            try
            {
                EntityB entityB = ABaseDbContext().EntitiesB.SingleOrDefault(eB => eB.Username == username);

                if (entityB != null)
                {
                    return ConvertBEntityToModel(entityB);
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public IEnumerable<ModelB> ReadEntities()
        {
            try
            {
                IEnumerable<EntityB> entitiesB = ABaseDbContext().EntitiesB.ToList();

                if (entitiesB.Any())
                {
                    return entitiesB.Select(ConvertBEntityToModel);
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<ModelB>();

        }

        public int DeleteEntity(ModelB modelB)
        {
            try
            {
                EntityB entityB = ABaseDbContext().EntitiesB.Find(modelB.Id);

                if (entityB != null)
                {
                    ABaseDbContext().EntitiesB.Remove(entityB);
                    Commit();
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return -1;
        }
    }
}
