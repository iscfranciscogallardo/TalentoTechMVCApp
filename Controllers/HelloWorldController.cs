using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get: /HellowWorld
        //public string Index()
        //{
        //    //return "This is my default action..."; este solo nos sirve para mostrar texto
        //}

        public IActionResult Index() { return View(); }

        //Get: /HellowWorld/Welcome
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = $"Hello {name}";
            ViewData["NumTimes"] = numTimes;
            return View();
        }

    }
}
