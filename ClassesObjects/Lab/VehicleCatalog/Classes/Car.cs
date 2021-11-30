using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    //Add interface for the car 
    internal class Car : Vehicle
    {
        private string housePower;
        public Car(string type, string brand, string model, string horsePower) : base(type, brand, model)
        {
            this.HorsePower = horsePower;
        }

        public string HorsePower
        {
            get => housePower;
            set
            {
                if (IsValidHorses(value))
                {
                    housePower = value;
                }
                else
                {
                    throw new ArgumentException("Invalid horses power!");
                }
            }
        }

        protected bool IsValidHorses(string power)
        {
            return int.Parse(power) > 0;
        }

        public override string GetAditionalValue()
        {
            return this.housePower+"hp";
        }
    }
}
