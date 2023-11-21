using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Dto
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
        public string categoryname { get; set; }
    }
}
