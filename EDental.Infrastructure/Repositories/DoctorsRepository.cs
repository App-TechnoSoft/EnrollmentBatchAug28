using EDental.Data;
using EDental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Repositories;

public interface IDoctorsRepository
{
    public List<Doctor> Get();
    public Doctor Get(int id);
    public int Insert(Doctor doctor);
    public int Edit(Doctor doctor);
    public int Delete(Doctor doctor);
}

public class DoctorsRepository(EDentalDbContext dbContext) : IDoctorsRepository
{
    private readonly EDentalDbContext db = dbContext;

    public List<Doctor> Get()
    {
        var doctors = db.Doctor.ToList(); // select * from doctor
        return doctors;
    }

    public Doctor Get(int id)
    {
        var doctor = db.Doctor.Find(id);
        return doctor;
    }

    public int Insert(Doctor doctor)
    {
        db.Doctor.Add(doctor);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }

    public int Edit(Doctor doctor)
    {
        db.Doctor.Update(doctor);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }

    public int Delete(Doctor doctor)
    {
        db.Doctor.Remove(doctor);
        var rowsAffected = db.SaveChanges();
        return rowsAffected;
    }
}
