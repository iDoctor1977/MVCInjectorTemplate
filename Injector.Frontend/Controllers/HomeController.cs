using System.Web.Mvc;
using Injector.Common.IModel;
using Injector.Frontend.Models;

namespace Injector.Frontend.Controllers
{
    public class HomeController : ABaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            IDataModel model = new FrontendModel
            {
                Id = 1,
                Name = "Filippo",
                Surname = "Foglia",
                Username = "IDoctor"
            };

            businessOperator.AddModel(model);
            model = businessOperator.GetModel(1);

            businessOperator.ToStringOperator();

            return View(model);
        }
    }
}