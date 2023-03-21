using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using WebApplication_G_E.Models;

namespace WebApplication_G_E.Controllers
{
    public class ManageStudentController : Controller
    {
        static List<Student> students = new List<Student>() {
        new Student(){
            id=1,
            name="Ali",
            Department="software",
            oop_degree=30,
            web_degree=40,
            AVG=0,
        }
        };
        public IActionResult getListStudent()
        {

            return View(students);
        }

        public IActionResult addStudent()
        {
            return View();
        }


        [HttpPost]
        public IActionResult addStudent(Student objStudent)
        {
            objStudent.AVG = getAvg(objStudent);

            students.Add(objStudent);
            return View("getListStudent", students);
        }

        public IActionResult Details(int id)
        {
            var stu = students.Find(i => i.id == id);
            return View(stu);
        }
        public IActionResult Edit(int id)
        {
            var stu = students.Find(i => i.id == id);
            return View(stu);
        }
        [HttpPost]
        public IActionResult Edit(Student update,int id)
        {
            var oldstu = students.Find(i => i.id == id);
          
            int ind= students.IndexOf(oldstu);
            update.AVG = getAvg(update);
            students[ind] = update;

            return View(nameof(getListStudent),students);
        }
        float getAvg(Student s)
        {
           return s.AVG = (s.oop_degree + s.web_degree)/2;

        }
    }
}
