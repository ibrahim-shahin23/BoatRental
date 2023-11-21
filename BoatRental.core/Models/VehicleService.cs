using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Models
{
    public class VehicleService
    {
        [Key]
        public int vechicleId { get; set; }
        public int ServiceId { get; set; }
        public Vehicle vehicle { get; set; }
        public Service service { get; set; }
        public DateTime ServiceDate { get; set; }
        public double Cost { get; set; }
    }
}
