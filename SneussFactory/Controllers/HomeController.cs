using Microsoft.AspNetCore.Mvc;

namespace SneussFactory.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}