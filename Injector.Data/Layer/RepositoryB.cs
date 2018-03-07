using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using Injector.Common.DTOModel;
using Injector.Common.IRepository;
using Injector.Common.IStore;

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

        public Guid CreateEntity(EntityB entityB)
        {
            try
            {
                if (entityB != null)
                {
                    entityB.Id = Guid.NewGuid();

                    ABaseDbContext().EntitiesB.Add(entityB);

                    return entityB.Id;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Guid.Empty;
        }

        public bool UpdateEntity(EntityB entityB)
        {
            EntityB original = ABaseDbContext().EntitiesB.Find(entityB.Id);

            try
            {
                if (original != null)
                {
                    original.Username = entityB.Username;
                    original.Email = entityB.Email;

                    return true;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return false;
        }

        public EntityB ReadEntityById(Guid id)
        {
            try
            {
                EntityB original = ABaseDbContext().EntitiesB.Find(id);

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

        public EntityB ReadEntityByUsername(string username)
        {
            try
            {
                EntityB original = ABaseDbContext().EntitiesB.SingleOrDefault(eB => eB.Username == username);

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

        public IEnumerable<EntityB> ReadEntities()
        {
            try
            {
                IEnumerable<EntityB> entitiesB = ABaseDbContext().EntitiesB.ToList();

                if (entitiesB.Any())
                {
                    return entitiesB;
                }
            }
            catch (Exception exception)
            {
                throw new DbUpdateException(GetType().FullName + " - " + MethodBase.GetCurrentMethod().Name, exception);
            }

            return Enumerable.Empty<EntityB>();
        }

        public bool DeleteEntity(EntityB entityB)
        {
            try
            {
                EntityB original = ABaseDbContext().EntitiesB.Find(entityB.Id);

                if (original != null)
                {
                    ABaseDbContext().EntitiesB.Remove(original);

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
