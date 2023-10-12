/*Ejercicio 1: Impresión de Números Pares


Escribe un programa
que muestre los números pares del 2 al 20. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresión_de_numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            for (i = 2; i < 21; i = i + 2)
            {
             Console.WriteLine(Convert.ToString(i));
            }
            Console.ReadKey();
           

        }
    }
}

