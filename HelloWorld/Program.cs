// =============================================================
// TEMA 1.1 - HOLA MUNDO
// =============================================================
// Este es tu primer programa en C#.
// Todo programa de C# empieza ejecutando el codigo de arriba
// hacia abajo, linea por linea.
// =============================================================

// Console.WriteLine() muestra un texto en la pantalla
// y despues salta a la siguiente linea.
Console.WriteLine("Hola, Mundo!");

// Puedes mostrar cualquier texto que quieras.
Console.WriteLine("Bienvenido al curso de C#");
Console.WriteLine("Este es tu primer programa.");

// ----------------------------------------------------------
// COMENTARIOS
// ----------------------------------------------------------
// Una linea que empieza con // es un "comentario".
// Los comentarios NO se ejecutan, son solo notas para el
// programador. Sirven para explicar el codigo.

/* Tambien puedes hacer comentarios
   de varias lineas usando
   barra-asterisco al inicio y al final */

// ----------------------------------------------------------
// Console.Write() vs Console.WriteLine()
// ----------------------------------------------------------
// Console.Write() muestra texto pero NO salta de linea.
// Console.WriteLine() muestra texto y SI salta de linea.

Console.Write("Hola ");   // <-- no salta de linea
Console.Write("Mundo ");  // <-- sigue en la misma linea
Console.WriteLine("!");   // <-- ahora si salta de linea

Console.WriteLine("Esta linea ya esta en la siguiente.");

// ----------------------------------------------------------
// PAUSAR EL PROGRAMA
// ----------------------------------------------------------
// Console.ReadKey() espera a que el usuario presione
// cualquier tecla antes de cerrar la ventana.
Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();
