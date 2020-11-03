using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WK6MVCLinkWithTableData.Models;
namespace WK6MVCLinkWithTableData.Controllers
{


    public class FacultyController : Controller
    {
        CollegeDBContext context = new CollegeDBContext();
             
        // GET: Faculty
        public ActionResult ShowFacultyNames()
        {
            List<Faculty> faculties = context.Faculties.ToList();


            return View(faculties);
        }
    }
}