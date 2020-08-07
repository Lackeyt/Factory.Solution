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
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
      var thisEngineer = _db.Engineers
          .Include(engi=>engi.Join)
          .ThenInclude(join=>join.Machine)
          .FirstOrDefault(engi=>engi.EngineerId = id);
      return View(thisEngineer);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engi=>engi.EngineerId = id);
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer)
    {
      _db.Entry(engineer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engi=>engi.EngineerId = id);
      return View(thisEngineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engi=>engi.EngineerId = id);
      _db.Engineeers.Remove(thisEngineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMachine(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engi=>engi.EngineerId = id);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int MachineId)
    {
      var joinExists = _db.EngineerMachine.FirstOrDefault(join=>join.MachineId = MachineId && join.EngineerId = engineer.EngineerId);
      if(JoinExists != null)
      {
        return RedirectToAction("Details", new {id = engineer.EngineerId});
      }

      if (MachineId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() {MachineId = MachineId, EngineerId = engineer.EngineerId});
      }

      _db.SaveChanges();
      return RedirectToAction("Details", new {id = engineer.EngineerId});
    }

    [HttpPost]
    public ActionResult DeleteMachine(int joinId, int EngineerId)
    {
      var joinEntry = _db.EngineerMachine.FirstOrDefault(entry=>entry.EngineerMachineId == joinId);
      _db.EngineerMachine.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = EngineerId});
    }
  }
}