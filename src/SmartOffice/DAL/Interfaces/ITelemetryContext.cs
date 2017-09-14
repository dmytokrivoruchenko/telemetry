using Microsoft.EntityFrameworkCore;
using SmartOffice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOffice.DAL.Interfaces
{
    public interface ITelemetryContext
    {
        DbSet<Indicator> Indicator { get; set; }
    }
}
