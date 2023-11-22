using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Package> Packages { get; set; }

        public Owner owner { get; set; }
        [ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }
        
    }
}
