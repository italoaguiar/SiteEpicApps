using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace EpicApps.Controllers
{
    public class NewsletterController : Controller
    {
        [HttpPost]
        public ContentResult Subscribe(string email)
        {
            try
            {
                MailList.Insert(email);
            }
            catch(Exception e)
            {
                return Content("Error:" + e.Message, "text/plain");
            }
            return Content("OK", "text/plain");
        }
    }
    public class MailList
    {
        public static void Insert(string email)
        {
            StreamWriter w = new StreamWriter(HostingEnvironment.MapPath("~/maillist.txt"), true);
            w.WriteLine(email);
            w.Flush();
            w.Close();
        }
    }
}