using System.Web.Mvc;
using Injector.Frontend.Models.ViewModelsA;

namespace Injector.Frontend.Controllers
{
    public class ControllerA : ABaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TestA()
        {
            ControllerViewModelA model = new ControllerViewModelA
            {
                Id = 1,
                Name = "Filippo",
                Surname = "Foglia",
                TelNumber = "3315787943",
                ModelB = operatorB.GetModel(1)
            };

            operatorA.AddModel(model);
            model = (ControllerViewModelA) operatorA.GetModel(1);

            operatorA.ToStringOperator();

            return View(model);
        }

    }
}