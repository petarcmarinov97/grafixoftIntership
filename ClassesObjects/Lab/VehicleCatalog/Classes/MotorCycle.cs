using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    public class MotorCycle : Vehicle, IFastVehicle
    {
        private string horsePower;
        private string color;
        public MotorCycle(string type, string brand, string model, string horsePower, string color) : base(type, brand, model)
        {
            this.HorsePower = horsePower;
            this.Color = color;
        }
        public string HorsePower
        {
            get => horsePower;
            set
            {
                if (IsValidHorses(value))
                {
                    horsePower = value;
                }
                else
                {
                    throw new ArgumentException("Invalid horses power!");
                }
            }
        }
        public string Color { get => color; set { color = value; } }
        protected bool IsValidHorses(string power)
        {
            return int.Parse(power) > 0;
        }
        public override string ToString()
        {
            return base.ToString() + HorsePower + "hp" + " | Color: " + Color;
        }
    }
}
