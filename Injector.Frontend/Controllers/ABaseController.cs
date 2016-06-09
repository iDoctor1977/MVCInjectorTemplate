using System.Web.Mvc;
using Injector.Common.IOperator;
using Injector.Frontend.Models.ViewModelsA;
using Injector.Frontend.Models.ViewModelsB;

namespace Injector.Frontend.Controllers
{
    public abstract class ABaseController : Controller
    {
        // questa funzione scritta così permette di generare la classe di tipo 'Operartor'
        // solo nel momento in cui viene espressamente richiesta e non
        // all'istanziamento della classe che eredita l'astrazione.
        public IOperatorA GetIstanceOfOperatorA
        {
            get { return FrontendStore.InstanceOfFrontendStore.GetBusinessSupplier().GenerateOperatorA(); }
        }

        public IOperatorB GetIstanceOfOperatorB
        {
            get { return FrontendStore.InstanceOfFrontendStore.GetBusinessSupplier().GenerateOperatorB(); }
        }

        public CreateViewModelA GetIstanceOfCreateViewModelA
        {
            get { return FrontendStore.InstanceOfFrontendStore.GetCreateViewModelA(); }
        }

        public CreateViewModelB GetIstanceOfCreateViewModelB
        {
            get { return FrontendStore.InstanceOfFrontendStore.GetCreateViewModelB(); }
        }

        protected ABaseController() { }

        protected ABaseController(IFrontendStore frontend)
        {
            FrontendStore.InstanceOfFrontendStore = frontend;
        }


    }
}