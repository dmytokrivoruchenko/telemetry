using SmartOffice.DAL.Interfaces;
using SmartOffice.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOffice.DAL.Repositories
{
    public class TelemetryRepository:ITelemetryRepository
    {
        private readonly ITelemetryContext _context;

        public TelemetryRepository(ITelemetryContext context)
        {
            _context = context;
        }

        public IQueryable<Indicator> Indicator => _context.Indicator;
    }
}
