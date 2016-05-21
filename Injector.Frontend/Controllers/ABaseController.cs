using System.Web.Mvc;
using Injector.Common.IOperator;
using Injector.Common.ISupplier;

namespace Injector.Frontend.Controllers
{
    public abstract class ABaseController : Controller
    {
        private IBusinessSupplier businessSupplier;

        protected ABaseController()
        {
            businessSupplier = FrontendInjector.GetBusinessSupplier(null);
        }

        protected ABaseController(IBusinessSupplier businessSupplier)
        {
            this.businessSupplier = FrontendInjector.GetBusinessSupplier(businessSupplier);
        }

        // questa funzione scritta così permette di generare la classe di tipo 'Operartor'
        // solo nel momento in cui viene espressamente richiesta e non
        // all'istanziamento della classe che eredita l'astrazione.
        public IInjectorOperator businessOperator
        {
            get { return businessSupplier.GenerateBusinessOperator(); }
        }
    }
}