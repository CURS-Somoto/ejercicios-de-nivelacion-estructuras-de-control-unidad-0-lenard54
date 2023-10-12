/*Ejercicio 5: Positivo o negativo


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero Para de la tabla de Multiplicar");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + "*" + i + "=" + resultado);
            }

            Console.ReadLine();

        }
    }
}

