using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id)

        {
            var db = new UserDbContext();

            SMS contacts = db.SMS.Find(id);
            db.SMS.Remove(contacts);

            return RedirectToAction("ContactDisplay");
        }
    }
}