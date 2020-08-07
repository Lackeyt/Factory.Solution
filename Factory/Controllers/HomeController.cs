using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public EngineersController(FactoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Machines = _db.Machines.ToList();
        ViewBag.Engineers = _db.Engineers.ToList();
        return View();
      }
    }
}