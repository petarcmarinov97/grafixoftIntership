using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VehicleCatalog
{
    public abstract class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private string type;

        public Vehicle(string type, string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
            this.Type = type;
        }

        public string Brand
        {
            get => brand;
            set
            {
                if (!HasValidBrand(value))
                {
                    throw new ArgumentException("Invalid brand name!");
                }

                brand = value;
            }
        }
        public string Model
        {
            get => model;
            set
            {
                if (!HasValidModel(value))
                {
                    throw new ArgumentException("Invalid model name!");
                }

                model = value;
            }
        }

        public string Type
        {
            get => type;
            set
            {
                type = value;
            }
        }
        public bool HasValidBrand(string brand)
        {
            bool isValid = brand.Length >= 2 && brand.Length <= 15;

            foreach (char c in brand)
            {
                if (!Char.IsLetter(c))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public bool HasValidModel(string model)
        {
            bool isValid = model.Length >= 2 && model.Length <= 15;

            foreach (char c in model)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public override string ToString()
        {
            return Type + " ---> " + Brand + " - " + Model + " - ";
        }
    }
}
