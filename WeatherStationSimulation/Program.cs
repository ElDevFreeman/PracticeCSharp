namespace WeatherStationSimulation
{
    internal class Program
    {
        



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");

            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];

            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };

            string[] weatherConditions = new string[days];

            Random random = new Random();

             int mathTemperatures = 0;

            for(int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
                mathTemperatures = mathTemperatures + temperature[i];

                int day = i + 1;

                Console.WriteLine("The temperature of the day " + day + " is: " + temperature[i]);
               
            }

            Console.WriteLine("This are the Average Temperature of the days: " + AverageTemperatures(mathTemperatures, temperature.Length));


            Console.WriteLine("The minumus temperature is: " + MinTemperature(temperature));
            Console.WriteLine("The maximun temperature is: " + MaxTemperature(temperature));
            Console.WriteLine("The most common condition is: " + MostCommonCondition(weatherConditions));
            Console.ReadLine();
        }


        static double AverageTemperatures(int mathTemperature, int qtyTemperature)
        {

            double averageTemp = (double)mathTemperature / qtyTemperature;

            return averageTemp;
        }


        static  int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature)
            {
                if(temp < min)
                {
                    min = temp;
                }
            }

            return min;
        }

        static int MaxTemperature(int[] temperature)
        {
            int max = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp > max)
                {
                    max = temp;
                }
            }

            return max;
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for(int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for(int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }



    }
}