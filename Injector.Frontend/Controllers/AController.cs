using System.Web.Mvc;
using Injector.Common.IStore;
using Injector.Frontend.Models;

namespace Injector.Frontend.Controllers
{
    public class AController : ABaseController
    {
        #region CONSTRUCTOR

        public AController() { }

        public AController(IWebStore webStore) : base(webStore) { }

        #endregion

        public ActionResult Index()
        {
            VMCreateA viewModelA = GetIstanceOfCreateViewModelA;
            GetIstanceOfOperatorA.CreateModel(viewModelA);
            viewModelA = (VMCreateA) GetIstanceOfOperatorA.ReadModel(1);

            return View(viewModelA);
        }

        public ActionResult Create(VMCreateA model)
        {
            VMCreateA vmCreateA = ABaseStore.NewVMCreateA as VMCreateA;

            vmCreateA.DTOModelA.Name = "Filippo";
            vmCreateA.DTOModelA.Surname = "Foglia";
            vmCreateA.TelNumber = "3315787943";

            VMCreateB vmCreateB = ABaseStore.NewVMCreateB as VMCreateB;
            vmCreateB.DTOModelB.Username = "iDoctor";
            vmCreateB.DTOModelB.Email = "filippo.foglia@gmail.com";
            vmCreateB.Birth = "18/07/1977";

            GetIstanceOfOperatorA.CreateModel(vmCreateA);
            GetIstanceOfOperatorB.CreateModel(vmCreateB);

            vmCreateA.ColCreateViewModelB.Add((VMCreateB)GetIstanceOfOperatorB.ReadModelByUsername("iDoctor"));

            return View(vmCreateA);
        }
    }
}