using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace FinalProject.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }



        [HttpPost]
        public async Task<ActionResult> Register(SMS register)
        {


            if (ModelState.IsValid)
            {

                SMS reg = new SMS();

                ViewBag.Name = reg.FirstName = register.FirstName;


                reg.LastName = register.LastName;
                reg.MobileNumber = register.MobileNumber;
                reg.RegisterPassword = register.RegisterPassword;
                reg.Username = register.Username;
            


                var db = new UserDbContext();
                db.SMS.Add(reg);
                await db.SaveChangesAsync();

                //reg.RegisterSMS();//Sends the message for registration


                 return View ("RegisterationComplete");
            }



            return View();
            

              

        }

       
    }
     
}
