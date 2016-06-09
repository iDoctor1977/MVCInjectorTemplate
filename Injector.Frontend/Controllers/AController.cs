using System.Web.Mvc;
using Injector.Frontend.Models.ViewModelsA;
using Injector.Frontend.Models.ViewModelsB;

namespace Injector.Frontend.Controllers
{
    public class AController : ABaseController
    {
        public AController() { }

        public AController(IFrontendStore frontendStore) : base(frontendStore) { }

        public ActionResult Index()
        {
            CreateViewModelA viewModelA = GetIstanceOfCreateViewModelA;
            GetIstanceOfOperatorA.CreateModel(viewModelA);
            viewModelA = (CreateViewModelA) GetIstanceOfOperatorA.ReadModel(1);

            return View(viewModelA);
        }

        public ActionResult Create(CreateViewModelA model)
        {
            CreateViewModelA viewModelA = FrontendStore.InstanceOfFrontendStore.GetCreateViewModelA();
            viewModelA.Name = "Filippo";
            viewModelA.Surname = "Foglia";
            viewModelA.TelNumber = "3315787943";

            CreateViewModelB viewModelB = FrontendStore.InstanceOfFrontendStore.GetCreateViewModelB();
            viewModelB.Username = "iDoctor";
            viewModelB.Email = "filippo.foglia@gmail.com";
            viewModelB.Birth = "18/07/1977";

            GetIstanceOfOperatorA.CreateModel(viewModelA);
            GetIstanceOfOperatorB.CreateModel(viewModelB);

            viewModelA.ColCreateViewModelB.Add((CreateViewModelB) GetIstanceOfOperatorB.ReadModelByUsername("iDoctor"));

            return View(viewModelA);
        }
    }
}