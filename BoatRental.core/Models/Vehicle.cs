using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Brand { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
        [ForeignKey("category")]
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public List<VehicleService> VehicleServices { get; set; }

        public Staff staff { get; set; }
        public Owner owner { get; set; }
    }
}
