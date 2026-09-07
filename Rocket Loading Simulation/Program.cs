
string rocket = "   /\\\n  /  \\\n  |  |\n  |  |\n /____\\\n |    |\n |NASA|\n |    |\n /|/\\|\\\n/_|__|_\\";
//Console.ReadKey();

int number = 25;

//for (int i = 2; i < number; i++)
//{
//    Console.WriteLine(rocket);
//    Thread.Sleep(1000);
//    for (int d = 1; d < number; d++)
//    {
//        Console.WriteLine("");

//        for (int c = 0; c < d; c++)
//        {
//            Console.Clear();
//        }
//    }
//}

//Console.ReadKey();

for (int i = 0; i < number; i++)
{
    Console.Clear();

    for (int d = 0; d < i; d++)
    {
        Console.WriteLine("");
    }

    Console.WriteLine(rocket);
    Thread.Sleep(1000);
}

Console.WriteLine();
Console.WriteLine("The rocket has landed. Woohoo! Another successful landing!");
Console.ReadKey();


//for (int i = 0; i <= 15; i++)
//{
//    Console.Clear();

//    for (int j = 0; j < i; j++)
//    {
//        Console.WriteLine();
//    }

//    Console.WriteLine(rocket);

//    Thread.Sleep(300);
//}

//Console.WriteLine();
//Console.WriteLine("The rocket has landed. Woohoo! Another successful landing!");



for(int counter = 10; counter >= 0; counter--)
{
    Console.Clear();
    Console.WriteLine("Counter is " + counter);
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep(1000);
}