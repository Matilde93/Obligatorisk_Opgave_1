using System;
using System.Reflection.Metadata.Ecma335;

namespace CarLib
{
    public class Car
    {
        
        private string _model;
        private double _price;
        private string _licensePlate;

        public int Id { get; set; }

        public Car(string model, double price, string licensePlate, int id)
        {
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
            Id = id;

        }

        public string Model
        {
            get => _model;
            set
            {
                if (value.Length < 4) { throw new ArgumentOutOfRangeException();}

                _model = value;
            }

        }

        public double Price
        {
            get => _price;
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException();}

                _price = value;
            }
             
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value.Length < 2 || value.Length > 7) {throw new ArgumentOutOfRangeException();}

                _licensePlate = value;
            }

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    }