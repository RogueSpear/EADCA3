using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class ServiceAuthor : IServiceAuthor_Code
    {
        string ConString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        Contacts c = new Contacts();
        
        public void DoWork()
        {

        }
        public Contacts ReturnAuthor()
        {
            using (con = new SqlConnection(ConString))
            {
                cmd = new SqlCommand("SELECT * FROM Contacts", con);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable("Paging");
                sda.Fill(dt);
                c.CustomersFriendNumber = dt.ToString();
                return c;
            }   

        }
    }
}