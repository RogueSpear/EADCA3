using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;
using FinalProject.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace FinalProject.Controllers
{
    
    public class DefaultController : Controller
    {
        
        // GET: Default


            // These are required for dependcies 

        [HttpGet]
        public ActionResult Nyform(String CustomersFriendNumber)

        {
            ViewBag.number = CustomersFriendNumber;


            return View();
        }


        public ActionResult Error()

        {


            return View("Error");
        }





        public ActionResult Congratulations()

        {


            return View();
        }







        [HttpPost] 
        public  ActionResult Nyform(SMS sms)

        {
            try {
                SMS test = new SMS();

                test.MobileNumber = sms.MobileNumber;

                test.SmsMessage = sms.SmsMessage;

                //sms.sendSMS();



                var db = new UserDbContext();




                db.SMS.Add(test);

                db.SaveChanges();












                if (ModelState.IsValid)
                {


                    // Makes sure that there is actually contacts in the list 
                    if (1 == 1)// Checks to see if the number is in the list 
                    {
                        Debug.WriteLine("Im sorry but I was unable to send the SMS" + "\nPersons area code  " + Session["MyPrefix"] + "Persons numbeer: " + Session["mynumber"]);
                        //Above is to allow for debugging functionality 



                        //sms.sendSMS();//Send the Real sms 
                


                    }

                    //Above is to allow for debugging functionality 


                }
               

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    } ViewBag.error = raise;
                }
                throw raise;
            }

            return View("Error");
        }
       

    }
}


    
