﻿using EDental.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Data.Models;
public class Appointment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string? Notes { get; set; }

    public int PatientId { get; set; }
    public Patient? Patient { get; set; }

    public int DoctorId { get; set; }
    public Doctor? Doctor { get; set; }
}
