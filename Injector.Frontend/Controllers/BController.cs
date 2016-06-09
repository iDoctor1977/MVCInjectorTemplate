using System.Web.Mvc;
using Injector.Common.IModel;
using Injector.Common.ISupplier;
using Injector.Frontend.Models.ViewModelsB;

namespace Injector.Frontend.Controllers
{
    public class BController : ABaseController
    {
        public BController() { }

        public BController(IFrontendStore frontendStore) : base(frontendStore) { }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TestB()
        {
            IModelB model = new CreateViewModelB
            {
                Username = "Idoctor",
                Email = "filippo.foglia@gmail.com",
                Birth = "18/07/1977"
            };

            GetIstanceOfOperatorB.CreateModel(model);
            model = (CreateViewModelB) GetIstanceOfOperatorB.ReadModel(1);

            GetIstanceOfOperatorB.ToStringOperator();

            return View(model);
        }

    }
}