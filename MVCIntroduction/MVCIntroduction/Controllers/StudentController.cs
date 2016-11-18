using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCIntroduction.Models;

namespace MVCIntroduction.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var model = new List<Team>();

            model.Add(new Team {Name = "MU"});
            model.Add(new Team {Name = "Chelsea"});

            return View(model);
        }

        /* public List<string> CreateStudentList()
         {
             List<string> students = new List<string>();

             students.Add("Jonas Bardačiokas");
             students.Add("Kazys Balkonas");
             students.Add("Bronius Lietpaltis");
             students.Add("Nerijus Upėtakius");

             return students;
         }*/
    }
}