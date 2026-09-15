// =============================================================
// TEMA 3.1 - METODOS
// =============================================================
// Un METODO es un bloque de codigo con nombre que puedes
// "llamar" (ejecutar) desde cualquier parte del programa.
//
// Para que sirven los metodos?
//   - Evitar repetir el mismo codigo varias veces
//   - Organizar el programa en partes mas pequenas
//   - Hacer el codigo mas facil de leer y entender
//
// Sintaxis basica:
//   tipoDeRetorno NombreDelMetodo(tipo parametro1, tipo parametro2)
//   {
//       // codigo del metodo
//       return valor;  // si el tipo no es void
//   }
// =============================================================


// ----------------------------------------------------------
// LLAMAR (invocar) los metodos definidos mas abajo
// El programa empieza aqui arriba y llama a cada metodo.
// ----------------------------------------------------------

Console.WriteLine("=== DEMO DE METODOS ===\n");

// Llamar un metodo simple sin parametros ni retorno:
Saludar();

// Llamar un metodo con parametros:
SaludarPersona("Carlos");
SaludarPersona("Ana");

// Llamar un metodo que retorna un valor:
int resultado = Sumar(10, 5);
Console.WriteLine("10 + 5 = " + resultado);

// Tambien puedes usar el resultado directamente:
Console.WriteLine("7 + 3 = " + Sumar(7, 3));

// Metodo con double:
double area = CalcularAreaRectangulo(4.5, 3.0);
Console.WriteLine($"Area del rectangulo: {area}");

// Metodo que retorna un string:
string mensaje = CrearSaludo("Pedro", 30);
Console.WriteLine(mensaje);

// Sobrecarga de metodos (mismo nombre, distintos parametros):
Console.WriteLine("\n--- Sobrecarga de Metodos ---");
Console.WriteLine(Describir(42));
//Console.WriteLine(Describir("texto de ejemplo"));
//Console.WriteLine(Describir(3.14));

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();


// ==============================================================
// DEFINICION DE METODOS
// Los metodos se definen despues del codigo principal.
// ==============================================================

// ----------------------------------------------------------
// METODO VOID - no retorna ningun valor
// "void" significa "vacio", no devuelve nada al llamador.
// ----------------------------------------------------------
void Saludar()
{
    Console.WriteLine("Hola desde el metodo Saludar!");
}

// ----------------------------------------------------------
// METODO VOID CON PARAMETRO
// Los parametros son valores que le pasas al metodo
// para que los use en su logica.
// ----------------------------------------------------------
void SaludarPersona(string nombre)
{
    // 'nombre' aqui es una variable LOCAL de este metodo
    Console.WriteLine($"Hola, {nombre}! Bienvenido al curso.");
}

// ----------------------------------------------------------
// METODO CON RETORNO
// El tipo antes del nombre indica que tipo de valor regresa.
// La palabra 'return' envia ese valor de vuelta al llamador.
// ----------------------------------------------------------
int Sumar(int numero1, int numero2)
{
    int suma = numero1 + numero2;
    return suma;  // <-- devuelve el resultado
}

// ----------------------------------------------------------
// METODO CON PARAMETROS double Y RETORNO double
// ----------------------------------------------------------
double CalcularAreaRectangulo(double ancho, double alto)
{
    return ancho * alto;  // puedes hacer el return directo
}

// ----------------------------------------------------------
// METODO QUE RETORNA UN STRING
// ----------------------------------------------------------
string CrearSaludo(string nombre, int edad)
{
    return $"Hola {nombre}! Tienes {edad} anos de edad.";
}

// ----------------------------------------------------------
// SOBRECARGA DE METODOS
// Puedes tener varios metodos con el MISMO NOMBRE siempre
// que tengan DISTINTOS parametros. C# sabe cual usar segun
// el tipo de dato que le pases.
// ----------------------------------------------------------
string Describir(int numero)
{
    return $"Es un numero entero: {numero}";
}

//string Describir(string texto)
//{
//    return $"Es un texto con {texto.Length} caracteres: \"{texto}\"";
//}

//string Describir(double numero)
//{
//    return $"Es un numero decimal: {numero}";
//}
