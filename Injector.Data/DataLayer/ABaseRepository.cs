using Injector.Data.ADOModel;

namespace Injector.Data.DataLayer
{
    public abstract class ABaseRepository
    {
        // questa funzione scritta così permette di generare la classe di tipo 'Operartor'
        // solo nel momento in cui viene espressamente richiesta e non
        // all'istanziamento della classe che eredita l'astrazione.
        public DataDbContext GetIstanceOfDataDbContext
        {
            get { return DataStore.InstanceOfDataStore.GetDataDbContext(); }
        }

        public EntityA GetIstanceOfEntityA
        {
            get { return DataStore.InstanceOfDataStore.GetEntityA(); }
        }

        public EntityB GetIstanceOfEntityB
        {
            get { return DataStore.InstanceOfDataStore.GetEntityB(); }
        }

        protected ABaseRepository() { }

        protected ABaseRepository(IDataStore dataStore)
        {
            DataStore.InstanceOfDataStore = dataStore;
        }
    }
}
