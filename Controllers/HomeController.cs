using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace azure_toolkit.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
