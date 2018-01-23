using System;
using System.Web;
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

        [HttpGet]
        public ActionResult Create()
        {
            VMCreateA vmCreateA = ABaseStore.NewVMCreateA as VMCreateA;
            vmCreateA.DTOModelA.Name = "Filippo";
            vmCreateA.DTOModelA.Surname = "Foglia";
            vmCreateA.TelNumber = "3315787943";

            return View(vmCreateA);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VMCreateA vmCreateA)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ABaseStore.StoreCoreSupplier.GetLogicA.CreatePost(vmCreateA);
                }
                catch (Exception exception)
                {
                    throw new HttpException(500, exception.Message, exception);
                }
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(Guid idA)
        {
            VMDeleteA vmDeleteA = ABaseStore.NewVMDeleteA as VMDeleteA;
            vmDeleteA.DTOModelA.Id = idA;
            vmDeleteA = ABaseStore.StoreCoreSupplier.GetLogicA.DeleteGet(vmDeleteA) as VMDeleteA;

            return View(vmDeleteA);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(VMDeleteA vmDeleteA)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ABaseStore.StoreCoreSupplier.GetLogicA.DeletePost(vmDeleteA);
                }
                catch (Exception exception)
                {
                    throw new HttpException(500, exception.Message, exception);
                }
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(Guid idA)
        {
            VMEditA vmEditA = ABaseStore.NewVMEditA as VMEditA;
            vmEditA.DTOModelA.Id = idA;
            vmEditA = ABaseStore.StoreCoreSupplier.GetLogicA.EditGet(vmEditA) as VMEditA;

            return View(vmEditA);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VMEditA vmEditA)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ABaseStore.StoreCoreSupplier.GetLogicA.EditPost(vmEditA);
                }
                catch (Exception exception)
                {
                    throw new HttpException(500, exception.Message, exception);
                }
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(Guid idA)
        {
            VMDetailsA vmDetailsA = ABaseStore.NewVMDetailsA as VMDetailsA;
            vmDetailsA.DTOModelA.Id = idA;
            vmDetailsA = ABaseStore.StoreCoreSupplier.GetLogicA.DetailsGet(vmDetailsA) as VMDetailsA;

            return View(vmDetailsA);
        }

        [HttpGet]
        public ActionResult List()
        {
            VMListA vmListA = ABaseStore.NewVMListA as VMListA;
            vmListA = ABaseStore.StoreCoreSupplier.GetLogicA.ListGet(vmListA) as VMListA;

            return View(vmListA);
        }
    }
}