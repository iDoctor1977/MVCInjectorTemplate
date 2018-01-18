using System;
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

        public Guid CreateEntity(ModelB modelB)
        {
            throw new NotImplementedException();
        }

        public int UpdateEntity(ModelB modelB)
        {
            throw new NotImplementedException();
        }

        public ModelB ReadEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public ModelB ReadEntityByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public int DeleteEntity(ModelB entityB)
        {
            throw new NotImplementedException();
        }
    }
}
