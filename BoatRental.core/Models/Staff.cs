using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Vehicle vehicle { get; set; }

        [ForeignKey("vehicle")]
        public int VehicleId {  get; set; }
        
    }
}
