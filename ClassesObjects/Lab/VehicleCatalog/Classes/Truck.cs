using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    public class Truck : Vehicle, ITruck
    {
        private string weight;

        public Truck(string type, string brand, string model, string weight) : base(type, brand, model)
        {
            this.Weight = weight;
        }

        public string Weight
        {
            get => weight;
            set
            {
                if (IsValidWeight(value))
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Invalid weight !");
                }
            }
        }

        protected bool IsValidWeight(string weight)
        {
            return int.Parse(weight) > 0;
        }

        public override string GetVehicleInfo()
        {
            string result = Type + " ---> " + Brand + " - " + Model + " - " + Weight + "kg";

            return result;
        }
    }
}
