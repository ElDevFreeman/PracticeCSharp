// =============================================================
// TEMA 1.2 - VARIABLES Y TIPOS DE DATOS
// =============================================================
// Una VARIABLE es un espacio en memoria donde guardamos
// un valor para usarlo despues.
//
// Para crear una variable necesitas:
//   1. El TIPO de dato (que tipo de valor va a guardar)
//   2. Un NOMBRE para identificarla
//   3. Un VALOR inicial (opcional pero recomendado)
//
// Sintaxis:  tipo nombre = valor;
// Ejemplo:   int edad = 25;
// =============================================================


// ----------------------------------------------------------
// TIPO: int  (numeros enteros, sin decimales)
// ----------------------------------------------------------
int edad = 25;
int anioNacimiento = 2001;
int temperatura = -5;  // puede ser negativo

Console.WriteLine("Edad: " + edad);
Console.WriteLine("Anio de nacimiento: " + anioNacimiento);
Console.WriteLine("Temperatura: " + temperatura);


// ----------------------------------------------------------
// TIPO: double  (numeros con decimales)
// ----------------------------------------------------------
double precio = 19.99;
double pi = 3.14159;
double descuento = -2.5;

Console.WriteLine("Precio: " + precio);
Console.WriteLine("Pi aproximado: " + pi);


// ----------------------------------------------------------
// TIPO: string  (texto, cadena de caracteres)
// Los strings siempre van entre comillas dobles: "texto"
// ----------------------------------------------------------
string nombre = "Maria";
string apellido = "Garcia";
string saludo = "Hola!";

Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Apellido: " + apellido);


// ----------------------------------------------------------
// TIPO: bool  (verdadero o falso, solo dos valores posibles)
// ----------------------------------------------------------
bool esMayorDeEdad = true;
bool tieneDescuento = false;
bool estaLloviendo = true;

Console.WriteLine("Es mayor de edad: " + esMayorDeEdad);
Console.WriteLine("Tiene descuento: " + tieneDescuento);


// ----------------------------------------------------------
// TIPO: char  (un SOLO caracter, va entre comillas simples)
// --------------------74--------------------------------------
char inicial = 'M';
char signo = '+';
char numero = '7';  // nota: esto es el CARACTER '7', no el numero 7

Console.WriteLine("Inicial: " + inicial);


// ----------------------------------------------------------
// OPERADORES ARITMETICOS
// ----------------------------------------------------------
int a = 10;
int b = 3;

int suma        = a + b;   // 13
int resta       = a - b;   // 7
int multiplicacion = a * b; // 30
int division    = a / b;   // 3  (division entera, descarta decimales)
int modulo      = a % b;   // 1  (el RESIDUO de la division)

Console.WriteLine("\n--- Operaciones con a=" + a + " y b=" + b + " ---");
Console.WriteLine("Suma:           " + suma);
Console.WriteLine("Resta:          " + resta);
Console.WriteLine("Multiplicacion: " + multiplicacion);
Console.WriteLine("Division:       " + division);
Console.WriteLine("Modulo:         " + modulo);

// Para obtener decimales en la division, usa double:
double divisionConDecimales = (double)a / b;  // 3.333...
Console.WriteLine("Division con decimales: " + divisionConDecimales);


// ----------------------------------------------------------
// CONCATENACION DE STRINGS (unir textos)
// ----------------------------------------------------------
string nombreCompleto = nombre + " " + apellido;
Console.WriteLine("\nNombre completo: " + nombreCompleto);

// Tambien puedes concatenar numeros con texto:
string mensaje = "Tienes " + edad + " anos de edad.";
Console.WriteLine(mensaje);


// ----------------------------------------------------------
// INTERPOLACION DE STRINGS (forma mas limpia de unir)
// Pones $ antes de las comillas y usas {variable} dentro
// ----------------------------------------------------------
string mensajeInterpolado = $"Hola {nombre}, tienes {edad} anos y mides {pi} metros... (broma)";
Console.WriteLine(mensajeInterpolado);

// Incluso puedes hacer calculos dentro de las llaves:
Console.WriteLine($"En 10 anos tendras {edad + 10} anos.");


// ----------------------------------------------------------
// OPERADORES DE COMPARACION
// Comparan dos valores y dan como resultado un bool (true/false)
// ----------------------------------------------------------
int x = 10;
int y = 20;

bool sonIguales   = x == y;   // false (10 no es igual a 20)
bool sonDiferentes = x != y;  // true  (10 si es diferente de 20)
bool esMenor      = x < y;    // true  (10 si es menor que 20)
bool esMayor      = x > y;    // false (10 no es mayor que 20)
bool menorOIgual  = x <= y;   // true
bool mayorOIgual  = x >= y;   // false

Console.WriteLine("\n--- Comparaciones con x=" + x + " y y=" + y + " ---");
Console.WriteLine($"x == y : {sonIguales}");
Console.WriteLine($"x != y : {sonDiferentes}");
Console.WriteLine($"x <  y : {esMenor}");
Console.WriteLine($"x >  y : {esMayor}");


// ----------------------------------------------------------
Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();
