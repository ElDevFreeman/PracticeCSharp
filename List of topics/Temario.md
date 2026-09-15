# Temario de C# - Guia de Aprendizaje

Este temario esta disenado para principiantes absolutos. Cada tema tiene su propio
proyecto de practica dentro de la solucion.

---

## Modulo 1 - Fundamentos

### Tema 1.1 - Hola Mundo (Proyecto: `HelloWorld`)
- Que es C# y .NET
- Estructura basica de un programa
- `Console.WriteLine()` para mostrar texto en pantalla
- `Console.ReadKey()` para pausar el programa
- Comentarios en el codigo (`//` y `/* */`)

### Tema 1.2 - Variables y Tipos de Datos (Proyecto: `VariablesYTipos`)
- Que es una variable
- Tipos de datos basicos:
  - `int`     — numeros enteros (ej: 5, -3, 100)
  - `double`  — numeros decimales (ej: 3.14, -0.5)
  - `bool`    — verdadero o falso (true / false)
  - `char`    — un solo caracter (ej: 'A', '3')
  - `string`  — cadena de texto (ej: "Hola Mundo")
- Declarar y asignar variables
- Operadores aritmeticos: `+`, `-`, `*`, `/`, `%`
- Operadores de comparacion: `==`, `!=`, `<`, `>`, `<=`, `>=`
- Concatenacion de strings con `+`
- Interpolacion de strings con `$"...{variable}..."`

---

## Modulo 2 - Control de Flujo

### Tema 2.1 - Condicionales e Interaccion (Proyecto: `TextAdventureGame`)
- `if` / `else if` / `else`
- Leer input del usuario con `Console.ReadLine()`
- Metodos de string: `.ToLower()`, `.ToUpper()`
- Clase `Random` para numeros aleatorios
- Bucle `while` y variable de control booleana
- Interpolacion de strings en la practica

### Tema 2.2 - Bucles (Proyecto: `LoopBasic`)
- Bucle `for`: inicializacion, condicion, incremento
- Bucle `foreach` (ver Modulo 3)
- Palabra clave `continue` para saltar iteraciones
- Palabra clave `break` para salir del bucle
- Bucles anidados

---

## Modulo 3 - Metodos

### Tema 3.1 - Metodos (Proyecto: `MetodosPractica`)
- Que es un metodo y para que sirve
- Definir un metodo: tipo de retorno, nombre, parametros
- Llamar (invocar) un metodo
- Metodos con parametros
- Metodos con valor de retorno (`return`)
- Metodos `void` (sin retorno)
- Sobrecarga de metodos (mismo nombre, distintos parametros)

---

## Modulo 4 - Arrays y Colecciones

### Tema 4.1 - Arrays (Proyecto: `Array`)
- Que es un array (arreglo)
- Declarar un array: `int[] miArray = new int[5]`
- Sintaxis moderna: `int[] miArray = [1, 2, 3]`
- Acceder a elementos por indice (empieza en 0)
- Propiedad `.Length`
- Recorrer un array con `for`
- Recorrer un array con `foreach`
- Arrays de distintos tipos: `int[]`, `string[]`, `double[]`

---

## Modulo 5 - Proyectos Creativos de Practica

Estos proyectos aplican todos los conceptos anteriores en programas mas complejos
y visuales. Son buenos para ver como se combina todo junto.

### Proyecto: `Rocket Loading Simulation`
- Conceptos usados: strings multilinea, loops anidados, `Console.Clear()`, `Thread.Sleep()`

### Proyecto: `UltraRocket`
- Conceptos usados: `Console.ForegroundColor`, `ConsoleColor`, `Console.SetCursorPosition()`,
  arrays, `Random`, animacion por coordenadas

### Proyecto: `TestAnimationLove`
- Conceptos usados: clases, `List<T>`, ANSI colors, `StringBuilder`, eventos,
  `try/finally`, P/Invoke, matematicas con `Math.Pow()`
- **Nota:** Este es el proyecto mas avanzado. Se recomienda revisarlo despues de
  dominar los modulos anteriores.

---

## Proximos temas (nivel intermedio)

Cuando se dominen los modulos anteriores, estos son los siguientes pasos:

- **Clases y Objetos** — Programacion Orientada a Objetos (OOP)
- **Listas (`List<T>`)** — Colecciones dinamicas
- **Manejo de Excepciones** — `try`, `catch`, `finally`
- **Interfaces y Herencia**
- **LINQ** — Consultas sobre colecciones
- **Delegados y Eventos**
- **Async / Await** — Programacion asincrona

---

*Ultima actualizacion: Septiembre 2026*
