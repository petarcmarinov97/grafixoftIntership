using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    internal class Truck : Vehicle
    {
        public Truck(string type, string brand, string model, string weight) : base(type, brand, model)
        {
            this.Weight = weight;
        }

        public string Weight { get; set; }

        public override string GetAditionalValue()
        {
            return this.Weight+"kg";
        }
    }
}
