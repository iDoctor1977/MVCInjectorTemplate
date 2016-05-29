using Injector.Common.IRepository;
using Injector.Common.ISupplier;

namespace Injector.Business.BusinessLayer
{
    public abstract class ABaseOperator
    {
        private IDataSupplier dataSupplier;

        // questa funzione scritta così permette di generare la classe di tipo 'Operartor'
        // solo nel momento in cui viene espressamente richiesta e non
        // all'istanziamento della classe che eredita l'astrazione.
        public IRepositoryA repositoryA
        {
            get { return dataSupplier.GenerateRepositoryA(); }
        }
        public IRepositoryB repositoryB
        {
            get { return dataSupplier.GenerateRepositoryB(); }
        }

        protected ABaseOperator()
        {
            dataSupplier = BusinessInjector.GetDataSupplier(null);
        }

        protected ABaseOperator(IDataSupplier dataSupplier)
        {
            this.dataSupplier = BusinessInjector.GetDataSupplier(dataSupplier);
        }
    }
}