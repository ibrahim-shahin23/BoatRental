using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        [ForeignKey(nameof(User))]
        public User user { get; set; }
    }
}
