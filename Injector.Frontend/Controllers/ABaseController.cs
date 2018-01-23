using System.Web.Mvc;
using Injector.Common.ILogic;
using Injector.Frontend.Models;

namespace Injector.Frontend.Controllers
{
    public abstract class ABaseController : Controller
    {
        // questa funzione scritta così permette di generare la classe di tipo 'Operartor'
        // solo nel momento in cui viene espressamente richiesta e non
        // all'istanziamento della classe che eredita l'astrazione.
        public ILogicA GetIstanceOfOperatorA
        {
            get { return FrontendStore.InstanceOfFrontendStore.GetBusinessSupplier().GetLogicA(); }
        }

        public ILogicB GetIstanceOfOperatorB
        {
            get { return FrontendStore.InstanceOfFrontendStore.GetBusinessSupplier().GetLogicB(); }
        }

        public VMCreateA GetIstanceOfCreateViewModelA
        {
            get { return FrontendStore.InstanceOfFrontendStore.GetCreateViewModelA(); }
        }

        public VMCreateB GetIstanceOfCreateViewModelB
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