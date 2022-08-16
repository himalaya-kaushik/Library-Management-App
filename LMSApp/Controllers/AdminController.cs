using Microsoft.AspNetCore.Mvc;

namespace LMSApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult addBooks()
        {
            return View();
        }
        
    }
}
