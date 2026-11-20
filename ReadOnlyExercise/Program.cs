namespace ReadOnlyExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Exercise men = new Exercise();

            men.Password = "password123";

            //Console.WriteLine(men.Password);
            
            men.PrintReadOnlyProperty();

        }
    }
}
