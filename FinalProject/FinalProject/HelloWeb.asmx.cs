using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FinalProject
{
    /// <summary>
    /// Summary description for HelloWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HelloWeb : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetMessage(string message)
        {
            Contacts contacts = new Contacts();
            UserDbContext db = new UserDbContext();
            var mycontacts = db.Contacts.ToList();
            return "Hello World\n" + mycontacts ;
        }
    }
}
