using System;

namespace CalculatingAverageTemperature
{
    public class Exercise
    {

        static void Main()
        {

            Console.WriteLine("How many temperatures you are going to entry? ");
            int qty = Convert.ToInt32(Console.ReadLine());


            double[] temperatures = new double[qty];

            for(int i = 0; i < qty; i++)
            {
                int number = 1 + i;

                Console.WriteLine("Write the temperature for the value: " +  i);

                temperatures[i] = Convert.ToDouble(Console.ReadLine());


            }

            PrintAverage(temperatures);

        }

        public static void PrintAverage(double[] temperatures)
        {
            Console.WriteLine("The average promedium of " + temperatures.Length + "is: ");

            Console.WriteLine(CalculateAverage(temperatures));
            Console.ReadLine();



        }

        public static double CalculateAverage(double[] temperatures)
        {
            double value = 0;

            //for (int i = 0;i < temperatures.Length;i++) 
            //{
            //     value = + temperatures[i];
            
            //}

            foreach(double tem in temperatures)
            {
                value += tem;
            }
            
            value = value / temperatures.Length;
            

            return value;

        }
    }
}