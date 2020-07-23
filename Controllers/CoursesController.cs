using System.Collections.Generic;
using aspnet.Models.Services.Application;
using aspnet.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace aspnet.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;

        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Lista corsi!!";

            List<CourseViewModel> courses = courseService.GetCourses();

            return View(courses);
        }

        public IActionResult Detail(string id)
        {

            ViewData["Title"] = "Dettaglio : " + id;
            return View();
        }

        public IActionResult DetailJSON(string id)
        {
            return Json("Ok. ID = " + id);
        }
    }
}