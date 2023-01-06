using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class MachineController : Controller
  {
    private readonly FactoryContext _db;

    public MachineController(FactoryContext db)
    {
      _db = db;
    }

    // Routes
    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      // validate
      if (!ModelState.IsValid)
      {
        return View(machine);
      }
      else
      {
        _db.Machines.Add(machine);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
        .Include(machine => machine.JoinEngineerMachine)
        // .ThenInclude(EngineerMachine => EngineerMachine.Engineer)
        .FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }


  }
}