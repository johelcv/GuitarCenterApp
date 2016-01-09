using GuitarCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuitarCenterWebSite.Controllers
{
    [Authorize]
    public class GuitarsController : Controller
    {
        private GuitarCenter.BL.IGuitarService GuitarService = new GuitarCenter.BL.GuitarService();
        // GET: Guitars
        public ActionResult Index()
        {
            var model = this.GuitarService.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = this.GuitarService.GetOne(id);
            return this.View(model);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Guitar Model)
        {
            if (this.ModelState.IsValid)
            {
                this.GuitarService.Create(Model);
                return this.RedirectToAction("Index");
            }
            else
            {
                return View(Model);
            }
        }
    }
}