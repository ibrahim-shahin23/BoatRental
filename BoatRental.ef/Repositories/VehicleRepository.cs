using BoatRental.core.Interfaces;
using BoatRental.core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.ef.Repositories
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        private readonly ApplicationDbContext _context;
        public VehicleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Vehicle> FindVehicle(int id)
        {
            var query = await _context.vehicles.Include(x => x.category).FirstOrDefaultAsync(x => x.Id == id);
            return query;
        }
    }
}
