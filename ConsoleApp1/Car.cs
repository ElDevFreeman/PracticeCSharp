using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Car
    {
        private string _model = "";
        private string _brand = "";

        public string Model { get => _model; set => _model = value; }
        public string Brand { get => _brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing");
                    _brand = "DefaultValue";

                }
                else 
                {
                    _brand = value;
                }
            }
        }

        public Car( string model, string brand)
        {
            Model = model;
            Brand = brand;


            Console.WriteLine($"The car model {Model} with the brand {Brand} was created");



        }

    }
}
 