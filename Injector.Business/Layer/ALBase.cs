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
            get { return CoreStore.InstanceOfBusinessStore.GetDataSupplier().GetRepositoryA(); }
        }

        public IRepositoryB GetIstanceOfRepositoryB
        {
            get { return CoreStore.InstanceOfBusinessStore.GetDataSupplier().GetRepositoryB(); }
        }

        public ModelA GetConcreteModelA
        {
            get { return CoreStore.InstanceOfBusinessStore.GetModelA(); }
        }

        public ModelB GetConcreteModelB
        {
            get { return CoreStore.InstanceOfBusinessStore.GetModelB(); }
        }

        protected ALBase() { }

        protected ALBase(IBusinessStore businessStore)
        {
            CoreStore.InstanceOfBusinessStore = businessStore;
        }
    }
}