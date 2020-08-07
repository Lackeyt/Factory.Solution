using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IndependentContracts.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
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
    public ActionResult Create(Engineer engineer)
    {

    }

    public ActionResult Edit(int id)
    {

    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer)
    {

    }

    public ActionResult Delete(int id)
    {

    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {

    }

    public ActionResult AddMachine(int id)
    {

    }

    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int MachineId)
    {

    }

    [HttpPost]
    public ActionResult DeleteMachine(int joinId)
    {

    }
  }
}