
        Console.Title = "Rocket Launch Simulator";
        Console.CursorVisible = false;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int width = 60;
        int height = 25;

        try { Console.SetWindowSize(width + 2, height + 3); } catch { }

        for (int i = 5; i >= 1; i--)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(width / 2 - 8, height / 2);
            Console.WriteLine("Launching in... " + i);
            Thread.Sleep(800);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(width / 2 - 5, height / 2);
        Console.WriteLine(">>> IGNITION! <<<");
        Thread.Sleep(1000);

        Random rnd = new Random();
        int[] starX = new int[40];
        int[] starY = new int[40];
        for (int s = 0; s < 40; s++)
        {
            starX[s] = rnd.Next(0, width);
            starY[s] = rnd.Next(0, height);
        }

        string[] rocket =
        {
            "   /\\",
            "  /  \\",
            " |    |",
            " |NASA|",
            " |    |",
            " /|##|\\",
            "/_|__|_\\"
        };

        int rocketX = width / 2 - 4;

        for (int y = height - rocket.Length; y >= -rocket.Length; y--)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            for (int s = 0; s < starX.Length; s++)
            {
                Console.SetCursorPosition(starX[s], starY[s]);
                Console.Write(rnd.Next(0, 5) == 0 ? "*" : ".");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < rocket.Length; i++)
            {
                int py = y + i;
                if (py >= 0 && py < height)
                {
                    Console.SetCursorPosition(rocketX, py);
                    Console.Write(rocket[i]);
                }
            }

            int fireY = y + rocket.Length;
            if (fireY < height)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(rocketX + 2, fireY);
                Console.Write(rnd.Next(0, 2) == 0 ? " /\\/\\ " : " \\/\\/ ");

                if (fireY + 1 < height)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(rocketX + 2, fireY + 1);
                    Console.Write(rnd.Next(0, 2) == 0 ? " **** " : "  **  ");
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, height);
            Console.Write(new string('=', width));

            Thread.Sleep(120);
        }

        for (int f = 0; f < 5; f++)
        {
            Console.Clear();
            Console.ForegroundColor = (f % 2 == 0) ? ConsoleColor.Yellow : ConsoleColor.Red;

            string[] boom =
            {
                "     *   *   *",
                "  *   *****   *",
                " *  *********  *",
                "  *   *****   *",
                "     *   *   *"
            };

            for (int i = 0; i < boom.Length; i++)
            {
                Console.SetCursorPosition(width / 2 - 8, height / 2 - 2 + i);
                Console.Write(boom[i]);
            }

            Thread.Sleep(200);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(width / 2 - 15, height / 2 - 1);
        Console.WriteLine("=================================");
        Console.SetCursorPosition(width / 2 - 15, height / 2);
        Console.WriteLine("   MISSION SUCCESS!  ");
        Console.SetCursorPosition(width / 2 - 15, height / 2 + 1);
        Console.WriteLine(" The rocket has launched!  ");
        Console.SetCursorPosition(width / 2 - 15, height / 2 + 2);
        Console.WriteLine("=================================");

        Console.ResetColor();
        Console.SetCursorPosition(0, height + 2);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
