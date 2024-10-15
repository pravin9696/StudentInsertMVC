using StudentInsertMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentInsertMVC.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult studInsert()
        {
            return View();
        }
        [HttpPost]
        public string studInsert(tblStudent std)
        {
            tempdbEntities dbo = new tempdbEntities();
            dbo.tblStudents.Add(std);
            int n=dbo.SaveChanges();
            if (n > 0)
            {
                return "Record inserted Successfully";
            }
            else
            {
                return "record not inserted!!!!!!!";
            }
            
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult StudRegistration()
        {
            return View();
        }
        [HttpPost]
        public string StudRegistration(tblStudent std)
        {
            SqlConnection con = new SqlConnection("Data Source=Desktop-ABKHEEV;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from tblStudent", con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adp);

            DataSet ds = new DataSet();
            adp.Fill(ds, "tblStudent");
            DataRow dr = ds.Tables["tblStudent"].NewRow();
            dr["Id"] = std.Id;
            dr["name"] = std.name;
            ds.Tables["tblStudent"].Rows.Add(dr);
            int n = 0;
            try
            {
                 n = adp.Update(ds, "tblStudent");
            }catch(Exception ex)
            { }
            if (n>0)
            {
                return "Record inserted Successfully";
            }
            else
            {
                return "record not inserted!!!!!!!";
            }
       
        }
    }
}