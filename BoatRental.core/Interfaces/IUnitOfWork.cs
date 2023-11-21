using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental.core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IVehicleRepository vehicles { get; }

        int Complete();
    }
}
