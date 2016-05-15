using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace FinalProject.Controllers
{
    public class AddContactController : Controller
    {
        // GET: AddContact
        public ActionResult MyContactadd()
        {
            return View();
        }


        [HttpPost]
        public ActionResult MyContactadd(Contacts addContact)
        {
            
                if (ModelState.IsValid)
                {

                    Contacts addcont = new Contacts();

                addcont.Username = Session["name"].ToString(); //ALows Session name to be used to add to new tabe acting as Primary key
                addcont.CustomersFriendNumber = addContact.CustomersFriendNumber;
                addcont.FirstName = addContact.FirstName;
              
                var db = new UserDbContext();
                    db.Contacts.Add(addcont);
                 db.SaveChanges();
            }
            return RedirectToAction("ContactDisplay", "Contacts");
                
            
           
                
            }
        }
    }
