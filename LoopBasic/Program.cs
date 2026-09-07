Console.WriteLine("Hello, World!");


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if(i == 2)
    {
        Console.WriteLine("I've had enought!");
        continue;
    }
    Console.WriteLine(i);
}