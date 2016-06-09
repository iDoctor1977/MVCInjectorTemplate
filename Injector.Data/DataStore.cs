using Injector.Data.ADOModel;
using Injector.Data.DataLayer;

namespace Injector.Data
{
    public interface IDataStore
    {
        DataDbContext GetDataDbContext();
        RepositoryA GetRepositoryA();
        RepositoryB GetRepositoryB();
        EntityA GetEntityA();
        EntityB GetEntityB();
    }

    internal class DataStore : IDataStore
    {
        private static IDataStore dataStore;
        private DataDbContext dataDbContext;
        private RepositoryA repositoryA;
        private RepositoryB repositoryB;

        public static IDataStore InstanceOfDataStore
        {
            get { return dataStore; }
            set { dataStore = value; }
        }

        public DataDbContext GetDataDbContext()
        {
            return dataDbContext ?? (dataDbContext = new DataDbContext());
        }

        public RepositoryA GetRepositoryA()
        {
            return repositoryA ?? (repositoryA = new RepositoryA());
        }

        public RepositoryB GetRepositoryB()
        {
            return repositoryB ?? (repositoryB = new RepositoryB());
        }

        public EntityA GetEntityA()
        {
            return new EntityA();
        }

        public EntityB GetEntityB()
        {
            return new EntityB();
        }
    }
}