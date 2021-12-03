﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog
{
    public class Car : Vehicle, IFastVehicles
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

        protected bool IsValidHorses(string power)
        {
            return int.Parse(power) > 0;
        }

        public override string GetVehicleInfo()
        {
            string result = Type + " ---> " + Brand + " - " + Model + " - " + HorsePower + "hp";
            
            return result;
        }
    }
}
