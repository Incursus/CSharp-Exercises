using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntroduction.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public List<string> CreateStudentList()
        {
            List<string> students = new List<string>();

            students.Add("Jonas Bardačiokas");
            students.Add("Kazys Balkonas");
            students.Add("Bronius Lietpaltis");
            students.Add("Nerijus Upėtakius");

            return students;
        }
    }
}