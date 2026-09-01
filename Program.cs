/* El programa solicitará un número al usuario y evaluará tres condiciones:

Si el número es mayor que 0.
Si el número es menor que 0.
Si el número es igual a 0. */

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

            Console.Write("\nIngrese un numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());   

            // condicional 1 .
            if (numero > 0)
            {
                Console.WriteLine("\nEl numero es POSITIVO!"); 
            }

            // condicional 2
            if (numero < 0)
            {
                Console.WriteLine("\nEl numero es NEGATIVO!");
            }

            // condicional 3
            if (numero == 0)
            {
                Console.WriteLine("\nEl numero es IGUAL a 0");
            }

            Console.WriteLine("\n====================================");
            Console.WriteLine("Presione una tecla para finalizar...");  
            Console.ReadKey();
        }
    }
}
