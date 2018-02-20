using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using Injector.Common.DTOModel;
using Injector.Common.IRepository;
using Injector.Common.IStore;
using Injector.Data.ADOModel;

namespace Injector.Data.Layers
{
    public class RepositoryA : ABaseRepository, IRepositoryA
    {
        private static IRepositoryA RepositoryAInstance { get; set; }

        #region CONSTRUCTOR

        private RepositoryA() { }

        private RepositoryA(IDataStore dataStore) : base(dataStore) { }

        #endregion

        #region SINGLETON

        public static IRepositoryA Instance()
        {
            if (RepositoryAInstance == null)
            {
                RepositoryAInstance = new RepositoryA();
            }

            return RepositoryAInstance;
        }

        public static IRepositoryA Instance(IDataStore dataStore)
        {
            if (RepositoryAInstance == null)
            {
                RepositoryAInstance = new RepositoryA(dataStore);
            }

            return RepositoryAInstance;
        }

        #endregion

        public Guid CreateEntity(ModelA modelA)
        {
            try
            {
                EntityA entityA = ConvertAModelToEntity(modelA) as EntityA;

                if (entityA != null)
                {
                    entityA.Id = Guid.NewGuid();
                    Commit();

                    return entityA.Id;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Guid.Empty;
        }

        public bool UpdateEntity(ModelA modelA)
        {
            EntityA entityA = ABaseDbContext().EntitiesA.Find(modelA.Id);

            try
            {
                if (entityA != null)
                {
                    entityA.Name = modelA.Name;
                    entityA.Surname = modelA.Surname;
                    Commit();

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return false;
        }

        public ModelA ReadEntityById(Guid id)
        {
            try
            {
                EntityA entityA = ABaseDbContext().EntitiesA.Find(id);

                if (entityA != null)
                {
                    return ConvertAEntityToModel(entityA);
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public ModelA ReadEntityByName(string name)
        {
            try
            {
                EntityA entityA = ABaseDbContext().EntitiesA.SingleOrDefault(eA => eA.Name == name);

                if (entityA != null)
                {
                    return ConvertAEntityToModel(entityA);
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public IEnumerable<ModelA> ReadEntities()
        {
            try
            {
                IEnumerable<EntityA> entitiesA = ABaseDbContext().EntitiesA.ToList();

                if (entitiesA.Any())
                {
                    return entitiesA.Select(ConvertAEntityToModel);
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<ModelA>();
        }

        public bool DeleteEntity(ModelA modelA)
        {
            try
            {
                EntityA entityA = ABaseDbContext().EntitiesA.Find(modelA.Id);

                if (entityA != null)
                {
                    ABaseDbContext().EntitiesA.Remove(entityA);
                    Commit();

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return false;
        }
    }
}
