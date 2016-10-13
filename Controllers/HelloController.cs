using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers
{
 public class HelloController : Controller                  
 {
    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        DateTime CurrentTime = DateTime.Now;  
        @ViewBag.CurrentTime = CurrentTime;

        return View("Index");
    }
    // [HttpPost]
    // [Route("")]
    // public IActionResult Other()
    // {
    //     return View();
    // }
 }
}