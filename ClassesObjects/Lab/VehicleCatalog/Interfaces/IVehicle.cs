using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    public interface IVehicle
    {
        string Type { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
    }
}