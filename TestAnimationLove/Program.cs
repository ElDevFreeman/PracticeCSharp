using System;
using System.Text;
using System.Threading;

namespace TeAmoRuby;

internal static class Program
{
    // ---------- Códigos ANSI ----------
    private const string RESET = "\u001b[0m";
    private const string BOLD = "\u001b[1m";
    private const string RED = "\u001b[91m";
    private const string PINK = "\u001b[95m";
    private const string MAGENTA = "\u001b[35m";
    private const string LIGHT_PINK = "\u001b[38;5;213m";
    private const string ROSE = "\u001b[38;5;211m";
    private const string WHITE = "\u001b[97m";
    private const string HIDE = "\u001b[?25l";
    private const string SHOW = "\u001b[?25h";

    private static readonly Random Rng = new();

    private static void Main()
    {
        // Habilitar UTF-8 y secuencias ANSI en Windows
        Console.OutputEncoding = Encoding.UTF8;
        EnableVirtualTerminal();

        Console.CancelKeyPress += (_, e) =>
        {
            Console.Write(SHOW + RESET);
            e.Cancel = false;
        };

        try
        {
            Console.Write(HIDE);
            HeartbeatScene();
            MessagesScene();
            HeartsRain(TimeSpan.FromSeconds(4));
            BuildHeart();
            FinalMessage();
        }
        finally
        {
            Console.Write(SHOW + RESET);
        }
    }

    // ---------- Utilidades ----------
    private static void ClearScreen() => Console.Clear();

    private static string Center(string text, int width = 80)
    {
        if (text.Length >= width) return text;
        int pad = (width - text.Length) / 2;
        return new string(' ', pad) + text;
    }

    private static void TypeText(string text, int delayMs = 40, string color = "")
    {
        foreach (char c in text)
        {
            Console.Write(color + c + RESET);
            Thread.Sleep(delayMs);
        }
        Console.WriteLine();
    }

    // ---------- ESCENA 1: Latido ----------
    private static void HeartbeatScene()
    {
        string[] smallHeart =
        {
            " ♥♥   ♥♥ ",
            "♥♥♥♥ ♥♥♥♥",
            "♥♥♥♥♥♥♥♥♥",
            " ♥♥♥♥♥♥♥ ",
            "  ♥♥♥♥♥  ",
            "   ♥♥♥   ",
            "    ♥    "
        };

        string[] bigHeart =
        {
            "  ♥♥♥♥♥     ♥♥♥♥♥  ",
            " ♥♥♥♥♥♥♥   ♥♥♥♥♥♥♥ ",
            "♥♥♥♥♥♥♥♥♥ ♥♥♥♥♥♥♥♥♥",
            "♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥",
            " ♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥ ",
            "  ♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥  ",
            "    ♥♥♥♥♥♥♥♥♥♥♥    ",
            "      ♥♥♥♥♥♥♥      ",
            "        ♥♥♥        "
        };

        for (int beat = 0; beat < 3; beat++)
        {
            ClearScreen();
            Console.WriteLine("\n\n");
            foreach (var line in smallHeart)
                Console.WriteLine(RED + Center(line, 60) + RESET);
            Thread.Sleep(400);

            ClearScreen();
            Console.WriteLine("\n");
            foreach (var line in bigHeart)
                Console.WriteLine(BOLD + RED + Center(line, 60) + RESET);
            Thread.Sleep(400);
        }
    }

    // ---------- ESCENA 2: Mensajes ----------
    private static void MessagesScene()
    {
        ClearScreen();
        Console.WriteLine("\n\n");

        (string color, string msg)[] messages =
        {
            (PINK,       "En el silencio de la noche..."),
            (LIGHT_PINK, "las estrellas susurran tu nombre..."),
            (ROSE,       "y mi corazón late al ritmo del tuyo..."),
            (MAGENTA,    "porque en ti encontré mi hogar.")
        };

        foreach (var (color, msg) in messages)
        {
            Console.WriteLine();
            TypeText("   " + msg, delayMs: 40, color: color + BOLD);
            Thread.Sleep(800);
        }

        Thread.Sleep(1500);
    }

    // ---------- ESCENA 3: Lluvia de corazones ----------
    private static void HeartsRain(TimeSpan duration)
    {
        const int width = 70;
        const int height = 20;
        string[] symbols = { "♥", "❤", "♡", "❥" };
        string[] colors = { RED, PINK, LIGHT_PINK, ROSE, MAGENTA };

        var drops = new System.Collections.Generic.List<Drop>();
        var start = DateTime.UtcNow;
        var buffer = new StringBuilder();

        while (DateTime.UtcNow - start < duration)
        {
            if (Rng.NextDouble() < 0.6)
            {
                drops.Add(new Drop
                {
                    X = Rng.Next(0, width),
                    Y = 0,
                    Sym = symbols[Rng.Next(symbols.Length)],
                    Color = colors[Rng.Next(colors.Length)],
                    Speed = Rng.Next(0, 3) == 0 ? 2 : 1
                });
            }

            var grid = new string[height, width];
            var colorGrid = new string[height, width];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    grid[y, x] = " ";

            var newDrops = new System.Collections.Generic.List<Drop>(drops.Count);
            foreach (var d in drops)
            {
                d.Y += d.Speed;
                if (d.Y < height && d.X >= 0 && d.X < width)
                {
                    grid[d.Y, d.X] = d.Sym;
                    colorGrid[d.Y, d.X] = d.Color;
                    newDrops.Add(d);
                }
            }
            drops = newDrops;

            ClearScreen();
            buffer.Clear();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (grid[y, x] != " ")
                        buffer.Append(colorGrid[y, x]).Append(grid[y, x]).Append(RESET);
                    else
                        buffer.Append(' ');
                }
                buffer.Append('\n');
            }
            Console.Write(buffer);
            Thread.Sleep(100);
        }
    }

    private sealed class Drop
    {
        public int X;
        public int Y;
        public int Speed;
        public string Sym = "♥";
        public string Color = RED;
    }

    // ---------- ESCENA 4: Corazón matemático ----------
    private static void BuildHeart()
    {
        ClearScreen();

        // Ecuación clásica del corazón: (x² + y² - 1)³ - x² y³ <= 0
        for (int y = 15; y >= -15; y--)
        {
            var line = new StringBuilder();
            for (int x = -30; x < 30; x++)
            {
                double xf = x * 0.05;
                double yf = y * 0.10;
                double v = Math.Pow(xf * xf + yf * yf - 1, 3) - xf * xf * yf * yf * yf;
                line.Append(v <= 0 ? "♥" : " ");
            }
            Console.WriteLine(BOLD + RED + line + RESET);
            Thread.Sleep(80);
        }
        Thread.Sleep(1000);
    }

    // ---------- ESCENA 5: Mensaje final ----------
    private static void FinalMessage()
    {
        ClearScreen();
        Thread.Sleep(500);

        string[] teAmo =
        {
            "████████╗███████╗     █████╗ ███╗   ███╗ ██████╗ ",
            "╚══██╔══╝██╔════╝    ██╔══██╗████╗ ████║██╔═══██╗",
            "   ██║   █████╗      ███████║██╔████╔██║██║   ██║",
            "   ██║   ██╔══╝      ██╔══██║██║╚██╔╝██║██║   ██║",
            "   ██║   ███████╗    ██║  ██║██║ ╚═╝ ██║╚██████╔╝",
            "   ╚═╝   ╚══════╝    ╚═╝     ╚═╝     ╚═╝ ╚═════╝ ",
        };

        string[] ruby =
        {
            "    ██████╗ ██╗   ██╗██████╗ ██╗   ██╗",
            "    ██╔══██╗██║   ██║██╔══██╗╚██╗ ██╔╝",
            "    ██████╔╝██║   ██║██████╔╝ ╚████╔╝ ",
            "    ██╔══██╗██║   ██║██╔══██╗  ╚██╔╝  ",
            "    ██║  ██║╚██████╔╝██████╔╝   ██║   ",
            "    ╚═╝  ╚═╝ ╚═════╝ ╚═════╝    ╚═╝   ",
        };

        Console.WriteLine("\n\n");
        foreach (var line in teAmo)
        {
            Console.WriteLine(BOLD + RED + Center(line, 80) + RESET);
            Thread.Sleep(150);
        }

        Console.WriteLine();
        foreach (var line in ruby)
        {
            Console.WriteLine(BOLD + PINK + Center(line, 80) + RESET);
            Thread.Sleep(150);
        }

        Console.WriteLine("\n");
        Thread.Sleep(500);

        string frase = "♥  Eres mi todo, mi razón, mi eternidad  ♥";
        Console.WriteLine(BOLD + LIGHT_PINK + Center(frase, 80) + RESET);
        Thread.Sleep(1000);

        string finalLine = "   ♥ ♥ ♥   Te amo, Ruby   ♥ ♥ ♥   ";
        for (int i = 0; i < 6; i++)
        {
            Console.Write("\r" + BOLD + RED + Center(finalLine, 80) + RESET);
            Thread.Sleep(400);
            Console.Write("\r" + new string(' ', 80));
            Thread.Sleep(300);
        }

        Console.WriteLine("\r" + BOLD + RED + Center(finalLine, 80) + RESET);
        Console.WriteLine();
        Console.WriteLine();
    }

    // ---------- Habilitar ANSI en Windows ----------
    private static void EnableVirtualTerminal()
    {
        if (!OperatingSystem.IsWindows()) return;

        try
        {
            const int STD_OUTPUT_HANDLE = -11;
            const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

            var handle = NativeMethods.GetStdHandle(STD_OUTPUT_HANDLE);
            if (handle == IntPtr.Zero) return;

            if (NativeMethods.GetConsoleMode(handle, out uint mode))
            {
                NativeMethods.SetConsoleMode(handle, mode | ENABLE_VIRTUAL_TERMINAL_PROCESSING);
            }
        }
        catch { /* si falla, no rompe la app */ }
    }

    private static class NativeMethods
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetStdHandle(int nStdHandle);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
    }
}