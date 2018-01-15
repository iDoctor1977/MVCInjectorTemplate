using Injector.Common.DTOModel;
using Injector.Common.IRepository;

namespace Injector.Business.Layer
{
    public abstract class ABaseOperator
    {
        // questa funzione scritta così permette di generare la classe di tipo 'Operartor'
        // solo nel momento in cui viene espressamente richiesta e non
        // all'istanziamento della classe che eredita l'astrazione.
        public IRepositoryA GetIstanceOfRepositoryA
        {
            get { return BusinessStore.InstanceOfBusinessStore.GetDataSupplier().GenerateRepositoryA(); }
        }

        public IRepositoryB GetIstanceOfRepositoryB
        {
            get { return BusinessStore.InstanceOfBusinessStore.GetDataSupplier().GenerateRepositoryB(); }
        }

        public ModelA GetConcreteModelA
        {
            get { return BusinessStore.InstanceOfBusinessStore.GetModelA(); }
        }

        public ModelB GetConcreteModelB
        {
            get { return BusinessStore.InstanceOfBusinessStore.GetModelB(); }
        }

        protected ABaseOperator() { }

        protected ABaseOperator(IBusinessStore businessStore)
        {
            BusinessStore.InstanceOfBusinessStore = businessStore;
        }
    }
}