/* Ejercicio 6: Pare e Impar


Escribe un programa que diga si un número
es par o impar.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else 
            {
                Console.WriteLine(" El numero es impar");
            }
            Console.ReadLine();
            
        }
    }
}

