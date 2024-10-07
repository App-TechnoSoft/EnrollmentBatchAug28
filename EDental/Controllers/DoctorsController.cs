
using EDental.Data;
using Microsoft.AspNetCore.Mvc;

public class DoctorsController: Controller
{
    public IActionResult Index()
    {
        // Fetch data from doctor table
        // ADO.NET
        // ORM Tool: EF Core, Dapper, NHibernate etc.
        
        var db = new EDentalDbContext();
        var doctors = db.Doctor.ToList(); // select * from doctor

        return View(doctors);
    }
}