using Microsoft.AspNetCore.Mvc;

namespace MyITProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
