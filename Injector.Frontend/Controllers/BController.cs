using System;
using System.Web;
using System.Web.Mvc;
using Injector.Common.IStore;
using Injector.Frontend.Models;

namespace Injector.Frontend.Controllers
{
    public class BController : ABaseController
    {
        #region CONSTRUCTOR

        public BController() { }

        public BController(IWebStore webStore) : base(webStore) { }

        #endregion

        [HttpGet]
        public ActionResult Create()
        {
            VMCreateB vmCreateB = ABaseStore.NewVMCreateB as VMCreateB;
            vmCreateB.DTOModelB.Username = "iDoctor";
            vmCreateB.DTOModelB.Email = "filippo.foglia@gmail.com";
            vmCreateB.Birth = "18/07/1977";

            return View(vmCreateB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VMCreateB vmCreateB)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ABaseStore.StoreCoreSupplier.GetLogicB.CreatePost(vmCreateB);
                }
                catch (Exception exception)
                {
                    throw new HttpException(500, exception.Message, exception);
                }
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(Guid idB)
        {
            VMDeleteB vmDeleteB = ABaseStore.NewVMDeleteB as VMDeleteB;
            vmDeleteB.DTOModelB.Id = idB;
            vmDeleteB = ABaseStore.StoreCoreSupplier.GetLogicB.DeleteGet(vmDeleteB) as VMDeleteB;

            return View(vmDeleteB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(VMDeleteB vmDeleteB)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ABaseStore.StoreCoreSupplier.GetLogicB.DeletePost(vmDeleteB);
                }
                catch (Exception exception)
                {
                    throw new HttpException(500, exception.Message, exception);
                }
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(Guid idB)
        {
            VMEditB vmEditB = ABaseStore.NewVMEditB as VMEditB;
            vmEditB.DTOModelB.Id = idB;
            vmEditB = ABaseStore.StoreCoreSupplier.GetLogicB.EditGet(vmEditB) as VMEditB;

            return View(vmEditB);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VMEditB vmEditB)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ABaseStore.StoreCoreSupplier.GetLogicB.EditPost(vmEditB);
                }
                catch (Exception exception)
                {
                    throw new HttpException(500, exception.Message, exception);
                }
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(Guid idB)
        {
            VMDetailsB vmDetailsB = ABaseStore.NewVMDetailsB as VMDetailsB;
            vmDetailsB.DTOModelB.Id = idB;
            vmDetailsB = ABaseStore.StoreCoreSupplier.GetLogicB.DetailsGet(vmDetailsB) as VMDetailsB;

            return View(vmDetailsB);
        }

        [HttpGet]
        public ActionResult List()
        {
            VMListB vmListB = ABaseStore.NewVMListB as VMListB;
            vmListB = ABaseStore.StoreCoreSupplier.GetLogicB.ListGet(vmListB) as VMListB;

            return View(vmListB);
        }
    }
}