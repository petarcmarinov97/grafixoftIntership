using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    internal class CatalogueVehicle
    {
        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }

        public CatalogueVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
