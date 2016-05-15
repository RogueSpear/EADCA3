using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;

namespace FinalProject.Models
{
    public class SMS
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("User Name")]
        
        public string Username { get; set; }


        [DisplayName("Your Password")]
        
        public string RegisterPassword { get; set; }
        [DisplayName("User First Name")]
       
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        
        public string LastName { get; set; }
        [DisplayName("Your Mobile Number")]
       
        public string MobileNumber { get; set; }

        public string youremail { get; set; }

        
        public string SmsMessage { get; set; }
       

        //Below is the APi for sending reall sms
        public string sendSMS()
        {
            String message = HttpUtility.UrlEncode("This is your message");
            using (var wb = new WebClient())
            {
                byte[] response = wb.UploadValues("http://api.txtlocal.com/send/", new NameValueCollection()
                {
                {"username" , "briannowlan@ymail.com"},
                {"hash" , "98219d896fd9b5be10a20ffcc503e0215c68f0ca"},
                {"numbers" , MobileNumber},
                {"message" , SmsMessage},
                {"sender" , "SMS.net"}
                });
                string result = System.Text.Encoding.UTF8.GetString(response);
                return result;
            }
        }


      
        }
    }
