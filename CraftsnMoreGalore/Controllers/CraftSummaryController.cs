using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CraftsnMoreGalore.Models;

namespace CraftsnMoreGalore.Controllers
{
    public class CraftSummaryController : Controller
    {
        // GET: CraftSummary
        public ActionResult CraftView(Craft craft)
        {
            return View(craft);
        }
    }
}