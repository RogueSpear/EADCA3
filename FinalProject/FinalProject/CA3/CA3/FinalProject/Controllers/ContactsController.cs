using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Delete()
        {
            return View();
        }


         //Makes a new contact with preloaded information

        
        /// <returns></returns>
        public async Task <ActionResult> ContactDisplay()

        {

            var db = new UserDbContext();

            // ViewBag.mycontacts = db.Contacts.ToList();

            // string query = "SELECT * FROM Contact WHERE Username = @p0";
            // Contacts department = await db.Contacts.SqlQuery(query, Session["name"]).SingleOrDefaultAsync();

            ServiceAuthor service = new ServiceAuthor();
            await db.SaveChangesAsync();
          return View(service.ReturnAuthor());
            
        }


    }
    }