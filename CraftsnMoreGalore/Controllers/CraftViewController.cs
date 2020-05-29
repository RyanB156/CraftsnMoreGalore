using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CraftsnMoreGalore.Models;
using CraftsnMoreGalore.DAL;

namespace CraftsnMoreGalore.Controllers
{
    public class CraftViewController : Controller
    {

        private CraftStoreContext db = new CraftStoreContext();

        // GET: CraftView
        [Route("Crafts")]
        public ActionResult Index()
        {
            var crafts = db.Crafts.ToList();
            return View(crafts);
        }

        public ActionResult Wreaths()
        {
            var crafts = db.Crafts.Where(c => c.Type == "Wreath").ToList();
            return View("Index", crafts);
        }

        public ActionResult Shirts()
        {
            var crafts = db.Crafts.Where(c => c.Type == "Shirt").ToList();
            return View("Index", crafts);
        }
    }
}