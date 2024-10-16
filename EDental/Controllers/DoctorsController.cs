
using EDental.Data;
using EDental.Data.Models;
using Microsoft.AspNetCore.Mvc;

public class DoctorsController: Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        // Fetch data from doctor table
        // ADO.NET
        // ORM Tool: EF Core, Dapper, NHibernate etc.
        
        var db = new EDentalDbContext();
        var doctors = db.Doctor.ToList(); // select * from doctor

        return View(doctors);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Doctor doctor)
    {
        // Save to db
        var db = new EDentalDbContext();
        db.Doctor.Add(doctor);
        db.SaveChanges();
    
        return RedirectToAction(nameof(Index));
    }
}