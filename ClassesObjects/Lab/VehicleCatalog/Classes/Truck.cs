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
                if (!HasValidWeight(value))
                {
                    throw new ArgumentException("Invalid weight !");
                }

                weight = value;
            }
        }

        private bool HasValidWeight(string weight)
        {
            return int.Parse(weight) > 0;
        }

        public override string ToString()
        {
            return base.ToString() + Weight + "kg";
        }
    }
}
