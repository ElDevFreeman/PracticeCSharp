using System;
using System.Collections.Generic;
using System.Numerics;
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



public class OuterClass
{
    private string outerField = "I belong to OuterClass";

    public class InnerClass
    {
        private OuterClass outer;

        public InnerClass(OuterClass outer)
        {
            this.outer = outer;
        }

        public void DisplayOuterField()
        {
            Console.WriteLine(outer.outerField);
        }
    }
}



class Program
{

    //public Vector Add(Vector other)
    //{
    //    return new Vector(this.X + other.X, this.Y + other.Y);
    //}


    static void Main()
    {
        OuterClass outerObject = new OuterClass();
        OuterClass.InnerClass innerObject = new OuterClass.InnerClass(outerObject);
        innerObject.DisplayOuterField();
    }
}