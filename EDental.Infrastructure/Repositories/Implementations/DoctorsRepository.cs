﻿using EDental.Data;
using EDental.Data.Models;
using EDental.Infrastructure.Repositories.Interfaces;

namespace EDental.Infrastructure.Repositories.Implementations;

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
