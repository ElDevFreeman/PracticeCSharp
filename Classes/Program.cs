namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Rectangle r1 = new Rectangle();
            //r1.Width = 10;

            //r1.Height = 5;

            //Console.WriteLine("Area of r1 is " + r1.Area);


            //Console.WriteLine("Please enter the firts number: ");

            Console.WriteLine("Please enter the number is going to duplicated: ");


            string? input = Console.ReadLine();

            if (int.TryParse(input, out int num1)) 
            {

                Console.WriteLine($"You entered: {num1}");

                num1 = StaticMethods.DoubleValue(  num1);

                Console.WriteLine("The double is "+ num1);
            }
            else
            {
                Console.WriteLine("Is not a number, the default result is 20");
            }

            Console.ReadKey(); 
        }
    }
}
