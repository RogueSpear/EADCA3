using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;
using System.Web.Security;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public async Task<ActionResult> Login(SMS login)
        {

            ViewBag.name = login.Username;
            Session["name"] = ViewBag.name;
            Session["password"] = login.RegisterPassword;

            var db = new UserDbContext();

            IQueryable<SMS> productsQuery = from product in db.SMS
                                            where product.Username == login.Username 
                                            
                                            select product;



            foreach (var prod in productsQuery)
            {


                if (ModelState.IsValid)
                {

                    if ((Session["name"]).Equals(prod.Username) && Session["password"].Equals(prod.RegisterPassword))
                    {



                        return RedirectToAction("Nyform","Default");//Only if user is authentitaced 
                    }
                }
                else
                {
                    return View("Error", "Default");

                }
               await db.SaveChangesAsync();
            }

            return View();
        }
    }
}

            

                
        
    
