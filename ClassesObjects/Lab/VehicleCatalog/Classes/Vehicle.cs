using System;
using System.Collections.Generic;
using System.Text;

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
                if (IsValidBrand(value))
                {
                    brand = value;
                }
                else
                {
                    throw new ArgumentException("Invalid brand name!");
                }
            }
        }
        public string Model
        {
            get => model;
            set
            {
                if (IsValidModel(value))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("Invalid model name!");
                }
            }
        }

        public string Type {
            get => type;
            set
            {
                type= value;
            }
        }

        protected bool IsValidBrand(string brand)
        {
            bool isValid = brand.Length >= 2 && brand.Length <= 15;

            foreach (char c in brand)
            {
                if (!Char.IsLetter(c))
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        protected bool IsValidModel(string model)
        {
                bool isValid = model.Length >= 2 && model.Length <= 15;

                foreach (char c in model)
                {
                    if (!Char.IsLetterOrDigit(c))
                    {
                        isValid = false;
                    }
                }

                return isValid;
            }

        public abstract string GetVehicleInfo();
    }
}
