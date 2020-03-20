using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpicApps.Controllers
{
    public class TranslationToolController : Controller
    {
        // GET: TranslationTool
        public ActionResult Index()
        {
            epic_apiEntities e = new epic_apiEntities();
            ViewBag.Apps = e.Apps.Where(p=> p.Ativo == true).ToList();
            ViewBag.Languages = e.Languages.ToList();
            return View();
        }
    }
}