using System.Collections.Generic;
using aspnet.Models.Services.Application;
using aspnet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace aspnet.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            ViewData["Title"] = "Lista corsi!!";

            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.getServices();

            return View(courses);            
        }

        public IActionResult Detail(string id){

            ViewData["Title"] = "Dettaglio : " + id;
            return View();            
        }

        public IActionResult DetailJSON(string id){            
            return Json("Ok. ID = " + id);
        }
    }
}