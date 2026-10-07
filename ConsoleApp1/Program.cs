namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car fusion = new Car("Fusion", "Ford");

            Console.WriteLine("Please enter the brand");

            fusion.Brand = Console.ReadLine();

            Console.WriteLine($"You entered {fusion.Brand}");

            Console.ReadKey();
        }
    }
}
