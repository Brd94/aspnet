using Microsoft.AspNetCore.Mvc;

namespace aspnet.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index(){
            return View();            
        }

        public IActionResult Detail(string id){
            return View();            
        }

        public IActionResult DetailJSON(string id){            
            return Json("Ok. ID = " + id);
        }
    }
}