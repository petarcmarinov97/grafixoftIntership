using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    internal class Truck : Vehicle, ITruck
    {
        private string weight;

        public Truck(string type, string brand, string model, string weight) : base(type, brand, model)
        {
            this.Weight = weight;
        }

        public string Weight {
            get =>weight;
            set
            {
            
            }

        public override string GetVehicleInfo()
        {
            string result = Type + " ---> " + Model + " - " + Brand + " - " + Weight + "kg";

            return result;
        }
    }
}
