using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Contacts
    {
        [Key]
        public int ID { get; set; }
       

        public string Username { get; set; }
        public string CustomersFriendNumber { get; set; }
        public string FirstName { get; set; }

    }
}