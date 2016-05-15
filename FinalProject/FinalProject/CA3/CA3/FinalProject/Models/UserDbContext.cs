using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject.Models;
using System.Data.Entity;

namespace FinalProject.Models
{
    public class UserDbContext : DbContext //Inherits from this class 
    {
        public UserDbContext() :base("DefaultConnection")
        {

        }

        public DbSet<SMS> SMS { get; set; }
        public DbSet<Contacts> Contacts { get; set; }


    }
}