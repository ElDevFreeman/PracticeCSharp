// =============================================================
// TEMA 2.2 - BUCLES (LOOPS)
// =============================================================
// Un BUCLE repite un bloque de codigo varias veces.
// Se usa cuando quieres hacer la misma accion multiples veces
// sin escribir el mismo codigo repetido.
// =============================================================

Console.WriteLine("Hello, World!");


// ----------------------------------------------------------
// BUCLE FOR
// ----------------------------------------------------------
// El bucle 'for' tiene 3 partes separadas por punto y coma:
//
//   for (inicializacion; condicion; incremento)
//
//   1. inicializacion : se ejecuta UNA sola vez al inicio
//                       (ej: int i = 0  --> crea la variable contadora)
//   2. condicion      : se verifica ANTES de cada repeticion
//                       si es true, ejecuta el bloque
//                       si es false, sale del bucle
//   3. incremento     : se ejecuta DESPUES de cada repeticion
//                       (ej: i++  --> suma 1 a i cada vuelta)
// ----------------------------------------------------------

for (int i = 0; i < 10; i++)
{
    // Este bloque se repite mientras i < 10
    // i toma los valores: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
    Console.WriteLine(i);

    if (i == 2)
    {
        // 'continue' salta inmediatamente a la SIGUIENTE iteracion
        // del bucle. El codigo que esta DESPUES del continue
        // NO se ejecuta en esa vuelta.
        Console.WriteLine("I've had enough!");
        continue;  // <-- salta al siguiente i (i=3), sin ejecutar el WriteLine de abajo
    }

    // Esta linea se ejecuta en todas las iteraciones EXCEPTO
    // cuando i == 2, porque el 'continue' la salta.
    Console.WriteLine(i);
}

// ----------------------------------------------------------
// RESULTADO ESPERADO:
// 0       <-- primera vez (i=0)
// 0       <-- segunda vez (i=0, no aplica continue)
// 1
// 1
// 2
// I've had enough!   <-- continue! la segunda linea NO se imprime
// 3
// 3
// ...y asi hasta i=9
// ----------------------------------------------------------

// ----------------------------------------------------------
// OTRAS PALABRAS CLAVE UTILES EN BUCLES:
//
// continue --> salta al inicio de la siguiente iteracion
// break    --> SALE del bucle completamente, termina el loop
// ----------------------------------------------------------
