using Injector.Common.DTOModel;
using Injector.Common.IRepository;

namespace Injector.Business.Layer
{
    public abstract class ALBase
    {
        // questa funzione scritta così permette di generare la classe di tipo 'Operartor'
        // solo nel momento in cui viene espressamente richiesta e non
        // all'istanziamento della classe che eredita l'astrazione.
        public IRepositoryA GetIstanceOfRepositoryA
        {
            get { return CoreStore.CoreStoreInstance.StoreDataSupplier().GetRepositoryA(); }
        }

        public IRepositoryB GetIstanceOfRepositoryB
        {
            get { return CoreStore.CoreStoreInstance.StoreDataSupplier().GetRepositoryB(); }
        }

        public ModelA GetConcreteModelA
        {
            get { return CoreStore.CoreStoreInstance.GetModelA(); }
        }

        public ModelB GetConcreteModelB
        {
            get { return CoreStore.CoreStoreInstance.GetModelB(); }
        }

        protected ALBase() { }

        protected ALBase(ICoreStore businessStore)
        {
            CoreStore.CoreStoreInstance = businessStore;
        }
    }
}