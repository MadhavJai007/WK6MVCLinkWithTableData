using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WK6MVCLinkWithTableData.Models;

namespace WK6MVCLinkWithTableData.Controllers
{
    public class StudentController : Controller
    {

        CollegeDBContext context = new CollegeDBContext();

        // GET: Student
        public ActionResult ShowStudentNamesByFaculty(int id)
        {
            List<Student> studentList = context.Students.Where(s => s.FacultyId == id).ToList();
            return View(studentList);
        }

        public ActionResult ShowStudentNames()
        {
            List<Student> studentList = context.Students.ToList();
            return View(studentList);
        }

        public ActionResult ShowSingleStudentDetails(int id)
        {

            Student student = context.Students.Single(stu => stu.Id == id);
            //Student student = (Student)context.Students.Where(x => x.Id == id); //LINQ Query where caluse along with Lambda expression
            return View(student);
        }
    }
}