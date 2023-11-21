using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Models
{
    public class ServicePackage
    {
        public int serviceId { get; set; }
        public int packageId { get; set; }
        public Service service { get; set; }
        public Package package { get; set; }    
    }
}
