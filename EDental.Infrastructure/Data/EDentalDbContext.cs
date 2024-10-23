using EDental.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EDental.Data;
public class EDentalDbContext: DbContext
{
    public DbSet<Doctor> Doctor { get; set; }
    public DbSet<Diagnosis> Diagnosis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EDentalDb;Integrated Security=True;");
    }
}
