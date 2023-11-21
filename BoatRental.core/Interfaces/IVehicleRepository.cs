using BoatRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Interfaces
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Task<Vehicle> FindVehicle(int id);
    }
}
