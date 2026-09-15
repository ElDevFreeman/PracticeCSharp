// =============================================================
// TEMA 2.1 - CONDICIONALES, INPUT Y BUCLE WHILE
// =============================================================
// Este proyecto es un pequeno juego de aventura de texto.
// Demuestra como combinar:
//   - Console.ReadLine()  para leer input del usuario
//   - if / else if / else para tomar decisiones
//   - while               para repetir mientras se cumpla una condicion
//   - Random              para generar numeros al azar
//   - String interpolation ($"...{variable}...")
// =============================================================

Console.WriteLine("Welcome to the Adventure game!");

// ----------------------------------------------------------
// LEER INPUT DEL USUARIO
// Console.ReadLine() espera a que el usuario escriba algo
// y presione Enter. Retorna un string con lo que escribio.
// ----------------------------------------------------------
Console.WriteLine("Enter your character's name: ");
string playerName = Console.ReadLine();

Console.WriteLine("Choose your character type (Warrior, Wizard, Archer)");
string characterType = Console.ReadLine();

// STRING INTERPOLATION: $"texto {variable} texto"
// Es mas limpio que concatenar con +
Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark forest");
Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");

string choice1 = Console.ReadLine();

// ----------------------------------------------------------
// CONDICIONALES: if / else if / else
// Evaluan una condicion y ejecutan el bloque correspondiente.
// Solo UNO de los bloques se ejecuta.
//
// .ToLower() convierte el string a minusculas para que
// "Enter", "ENTER" y "enter" sean reconocidos igual.
// ----------------------------------------------------------
if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely enter the forest");
}
else if (choice1.ToLower() == "camp")
{
    Console.WriteLine("You decide to camp out and wait for daylight.");
}
else
{
    // Este bloque se ejecuta si ninguna opcion anterior fue verdadera
    Console.WriteLine("Your option is not valid");
}


// ----------------------------------------------------------
// BUCLE WHILE
// Se repite MIENTRAS la condicion sea verdadera (true).
// Cuando la condicion sea false, el bucle termina.
//
// PELIGRO: si la condicion nunca se vuelve false,
// el bucle es infinito y el programa nunca termina.
// Por eso usamos 'gameContinues = false' para salir.
// ----------------------------------------------------------
bool gameContinues = true;  // variable de control del bucle

while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Go left or right?");
    string direction = Console.ReadLine();

    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;  // <-- esto hace que el while termine
    }
    else
    {
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("Fight or flee? (fight/flee)");
        string fightChoice = Console.ReadLine();

        if (fightChoice.ToLower() == "fight")
        {
            // --------------------------------------------------
            // CLASE RANDOM: genera numeros aleatorios
            // new Random()        --> crea el generador
            // random.Next(1, 11)  --> numero entre 1 y 10
            //                        (el limite superior es EXCLUSIVO)
            // --------------------------------------------------
            Random random = new Random();
            int luck = random.Next(1, 11);  // luck sera 1, 2, 3... o 10

            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beast!");

                // Condicional anidado (un if dentro de otro if):
                if (luck > 8)
                {
                    Console.WriteLine("The wild beast dropped a treasure!");
                }
            }
            else
            {
                Console.WriteLine("You are dead");
                gameContinues = false;  // <-- el juego termina
            }
        }
    }
}

// ----------------------------------------------------------
// Pausa al final para que el usuario pueda leer el resultado
// ----------------------------------------------------------
Console.ReadKey();
