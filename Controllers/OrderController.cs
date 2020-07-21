using Microsoft.AspNetCore.Mvc;

namespace aspnet.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(){
            return Content("Ok");            
        }

        public IActionResult Detail(string id){
            return Content("Ok. ID = " + id);            
        }

        public IActionResult DetailJSON(string id){            
            return Json("Ok. ID = " + id);
        }
    }
}