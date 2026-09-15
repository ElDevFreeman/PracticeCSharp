// =============================================================
// TEMA 4.1 - ARRAYS (ARREGLOS)
// =============================================================
// Un ARRAY es una coleccion de elementos del MISMO tipo,
// guardados en posiciones consecutivas en memoria.
//
// Para que sirve un array?
// En lugar de declarar 7 variables separadas para los dias
// de la semana, puedes tener UN array con los 7 valores.
//
// IMPORTANTE: los indices empiezan en 0, no en 1.
//   Posicion: [0]  [1]  [2]  [3]  [4]
//   Valor:     5    3    4    6    7
// =============================================================

Console.WriteLine("Hello, World!");


// ----------------------------------------------------------
// FORMA 1: Declarar array vacio y asignar valores despues
// Sintaxis: tipo[] nombre = new tipo[tamanio];
// ----------------------------------------------------------

// Esto crea un array de 5 enteros, todos en 0 por default.
int[] myIntArray = new int[5];

// Asignamos cada posicion por separado (indice empieza en 0):
myIntArray[0] = 5;
myIntArray[1] = 3;
myIntArray[2] = 4;
myIntArray[3] = 6;
myIntArray[4] = 7;

// Acceder a un elemento por su indice:
Console.WriteLine("Elemento en posicion 3: " + myIntArray[3]);  // imprime 6


// ----------------------------------------------------------
// FORMA 2: Declarar e inicializar con valores (sintaxis moderna)
// Sintaxis: tipo[] nombre = [val1, val2, val3, ...];
// ----------------------------------------------------------
int[] secondIntArray = [5, 5, 6, 4, 8];

Console.WriteLine("Elemento en posicion 3: " + secondIntArray[3]);  // imprime 4

// Pausa para que el usuario vea los resultados
Console.ReadKey();


// ----------------------------------------------------------
// ARRAYS DE STRINGS (texto)
// ----------------------------------------------------------
string[] weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

// La propiedad .Length indica cuantos elementos tiene el array:
Console.WriteLine("Numero de dias en la semana: " + weekDays.Length);  // 7


// ----------------------------------------------------------
// RECORRER UN ARRAY CON BUCLE FOR
// Usamos el indice i para acceder a cada posicion.
// Condicion: i < weekDays.Length  (evita salirse del array)
// ----------------------------------------------------------
Console.WriteLine("\n--- Dias con bucle for ---");
for (int i = 0; i < weekDays.Length; i++)
{
    // weekDays[i] accede al elemento en la posicion i
    Console.WriteLine(weekDays[i]);
}


// ----------------------------------------------------------
// RECORRER UN ARRAY CON FOREACH
// Forma mas simple: no necesitas manejar el indice.
// La variable 's' toma el valor de cada elemento automaticamente.
// Sintaxis: foreach (tipo variable in array)
// ----------------------------------------------------------
Console.WriteLine("\n--- Dias con foreach ---");
foreach (string s in weekDays)
{
    // 's' vale "Monday" en la primera vuelta,
    // "Tuesday" en la segunda, etc.
    Console.WriteLine(s);
}

// ----------------------------------------------------------
// DIFERENCIA ENTRE for Y foreach:
// - 'for'     --> necesitas el indice (util si necesitas saber la posicion)
// - 'foreach' --> mas simple, ideal cuando solo necesitas el valor
// ----------------------------------------------------------
