﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDental.Infrastructure.Data.Models;
public class Patient: Person
{
    public string? Symptoms { get; set; }
}
