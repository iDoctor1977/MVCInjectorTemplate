using System.Web.Mvc;
using Injector.Frontend.Models.ViewModelsB;

namespace Injector.Frontend.Controllers
{
    public class ControllerB : ABaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TestB()
        {
            ControllerViewModelB model = new ControllerViewModelB
            {
                Id = 1,
                Username = "Idoctor",
                Email = "filippo.foglia@gmail.com",
                Birth = "18/07/1977"
            };

            operatorB.AddModel(model);
            model = (ControllerViewModelB) operatorB.GetModel(1);

            operatorB.ToStringOperator();

            return View(model);
        }

    }
}