using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOffice.DAL.Models
{
    public class Indicator
    {
        public int Indicatorid { get; set; }
        public string Room { get; set; }
        public byte Temperature { get; set; }
        public byte Humidity { get; set; }
        public DateTime Dateandtime { get; set; }
    }
}
