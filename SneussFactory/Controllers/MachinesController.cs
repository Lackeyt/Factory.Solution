using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IndependentContracts.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SneussFactory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly SneussFactoryContext _db;

    public MachinesController(SneussFactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {

    }

    public ActionResult Details(int id)
    {

    }

    public ActionResult Create()
    {

    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {

    }

    public ActionResult Edit(int id)
    {

    }

    [HttpPost]
    public ActionResult Edit(Machine machine)
    {

    }

    public ActionResult Delete(int id)
    {

    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {

    }

    public ActionResult AddEngineer(int id)
    {

    }

    [HttpPost]
    public ActionResult AddEngineer(Machine machine, int EngineerId)
    {

    }

    [HttpPost]
    public ActionResult DeleteEngineer(int joinId)
    {
      
    }
  }
}