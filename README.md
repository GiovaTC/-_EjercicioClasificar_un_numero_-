# -_EjercicioClasificar_un_numero_- :.

```

🧮 Ejercicio: Clasificar un número

```

<img width="1280" height="1079" alt="image" src="https://github.com/user-attachments/assets/9daa2fed-92e3-4580-92d2-64df7b0f65c5" />    


```

El programa solicitará un número al usuario y evaluará tres condiciones:

Si el número es mayor que 0.
Si el número es menor que 0.
Si el número es igual a 0.

```

Código completo:

Ejercicio: 3 Condicionales en C#

```
using System;

namespace EjercicioTresCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("     EJERCICIO: 3 CONDICIONALES");
            Console.WriteLine("====================================");

            Console.Write("\nIngrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // Condicional 1
            if (numero > 0)
            {
                Console.WriteLine("\nEl número es POSITIVO.");
            }

            // Condicional 2
            if (numero < 0)
            {
                Console.WriteLine("\nEl número es NEGATIVO.");
            }

            // Condicional 3
            if (numero == 0)
            {
                Console.WriteLine("\nEl número es CERO.");
            }

            Console.WriteLine("\n====================================");
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
```

```
▶️ Ejemplo de ejecucion:

Si ingresamos:

Ingrese un número: 25

Obtendremos:
El número es POSITIVO.

Si ingresamos:
Ingrese un número: -8

Obtendremos:
El número es NEGATIVO.

Y si ingresamos:
Ingrese un número: 0

Obtendremos:
El número es CERO.

📚 Lo que se practica:
Elemento	          Uso
Console.WriteLine()	Mostrar información
Console.ReadLine()	Leer datos
Convert.ToDouble()	Convertir texto a número
if	                Evaluar condiciones
>	Mayor que
<	Menor que
==	Igual que

Este ejercicio es ideal para comenzar porque utiliza exactamente tres condicionales independientes if, sin introducir todavía else ni switch .
``` :. . / .
