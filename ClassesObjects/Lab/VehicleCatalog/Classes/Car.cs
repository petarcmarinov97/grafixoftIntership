using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    public class Car : Vehicle, IFastVehicle
    {
        private string horsePower;

        public Car(string type, string brand, string model, string horsePower) : base(type, brand, model)
        {
            this.HorsePower = horsePower;
        }
        public string HorsePower
        {
            get => horsePower;
            set
            {
                if (!HasValidHorsePowers(value))
                {
                    throw new ArgumentException("Invalid horses power!");
                }

                horsePower = value;
            }
        }
        protected bool HasValidHorsePowers(string power)
        {
            return int.Parse(power) > 0;
        }
        public override string ToString()
        {
            return base.ToString() + HorsePower + "hp";
        }
    }
}
