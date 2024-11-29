using EDental.Data.Models;
using EDental.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EDental.Data;
public class EDentalDbContext: IdentityDbContext
{
    public DbSet<Doctor> Doctor { get; set; }
    public DbSet<Diagnosis> Diagnosis { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Procurement> Procurements { get; set; }
    public DbSet<TreatmentPlan> TreatmentPlans { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EDentalDb;Integrated Security=True;");
    }
}
