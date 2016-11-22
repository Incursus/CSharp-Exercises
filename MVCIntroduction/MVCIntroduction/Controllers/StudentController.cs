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
            return View();
        }


        public ActionResult DisplayStudentNames()
        {
            List<StudentModel> students = new List<StudentModel>();

            students.Add(new StudentModel() {Name = "Redas Krik"});
            students.Add(new StudentModel() {Name = "Darius Krik"});

            return View(students);
        }
    }
}