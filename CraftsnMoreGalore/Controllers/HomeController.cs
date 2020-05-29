using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CraftsnMoreGalore.Models;
using CraftsnMoreGalore.ViewModels;
using CraftsnMoreGalore.Helpers;
using CraftsnMoreGalore.DAL;

namespace CraftsnMoreGalore.Controllers
{
    public class HomeController : Controller
    {

        private CraftStoreContext db = new CraftStoreContext();
            
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var Crafts = db.Crafts;
            var vm = new CraftListViewModel() { Crafts = db.Crafts.ToList().RandomElements(6) };

            return View(vm);
        }

        public ActionResult CraftView(int id)
        {
            var craft = db.Crafts.Where(c => c.Id == id).FirstOrDefault();

            if (craft == null)
            {
                return HttpNotFound();
            }
            else
            {
                return RedirectToAction("CraftView", "CraftSummary", craft);
            }            
        }

    }
}