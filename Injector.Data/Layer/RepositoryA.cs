using System;
using System.Data.Entity.Infrastructure;
using System.Reflection;
using Injector.Common.DTOModel;
using Injector.Common.IRepository;
using Injector.Common.IStore;
using Injector.Data.ADOModel;

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

        public int UpdateEntity(ModelA modelA)
        {
            EntityA entityA = ABaseDbContext().EntitiesA.Find(modelA.Id);

            try
            {
                if (entityA != null)
                {
                    entityA.Name = modelA.Name;
                    entityA.Surname = modelA.Surname;
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

        public ModelA ReadEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public ModelA ReadEntityByName(string name)
        {
            throw new NotImplementedException();
        }

        public int DeleteEntity(ModelA modelA)
        {
            throw new NotImplementedException();
        }
    }
}
