using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using Injector.Common.DTOEntity;
using Injector.Common.IRepository;
using Injector.Common.IStore;

namespace Injector.Data.Layer
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

        public Guid CreateEntity(EntityA entityA)
        {
            try
            {
                if (entityA != null)
                {
                    entityA.Id = Guid.NewGuid();

                    ABaseDbContext().EntitiesA.Add(entityA);

                    return entityA.Id;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Guid.Empty;
        }

        public bool UpdateEntity(EntityA entityA)
        {
            EntityA original = ABaseDbContext().EntitiesA.Find(entityA.Id);

            try
            {
                if (original != null)
                {
                    original.Name = entityA.Name;
                    original.Surname = entityA.Surname;

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return false;
        }

        public EntityA ReadEntityById(Guid id)
        {
            try
            {
                EntityA original = ABaseDbContext().EntitiesA.Find(id);

                if (original != null)
                {
                    return original;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public EntityA ReadEntityByName(string name)
        {
            try
            {
                EntityA original = ABaseDbContext().EntitiesA.SingleOrDefault(eA => eA.Name == name);

                if (original != null)
                {
                    return original;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return null;
        }

        public IEnumerable<EntityA> ReadEntities()
        {
            try
            {
                IEnumerable<EntityA> entitiesA = ABaseDbContext().EntitiesA.ToList();

                if (entitiesA.Any())
                {
                    return entitiesA;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<EntityA>();
        }

        public bool DeleteEntity(EntityA entityA)
        {
            try
            {
                EntityA original = ABaseDbContext().EntitiesA.Find(entityA.Id);

                if (original != null)
                {
                    ABaseDbContext().EntitiesA.Remove(original);

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
