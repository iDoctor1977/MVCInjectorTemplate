using System.Web.Mvc;

namespace Injector.Frontend.Controllers
{
    public class HomeController : ABaseController
    {
        public ActionResult Index()
        {
            return RedirectToAction("Create", "A");
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
    }
}