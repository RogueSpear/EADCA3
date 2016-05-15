using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class DbController : Controller
    {
        // GET: Db
        public ActionResult WCFDisplay()
        {

            ServiceReference1.Service1Client db = new ServiceReference1.Service1Client();
          
            
            return View(db.GetConacts());

        }
    }
}