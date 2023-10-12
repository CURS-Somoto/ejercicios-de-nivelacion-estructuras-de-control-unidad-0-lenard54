/*Ejercicio 3: Numero primo


Escribe un
programa que determine si un número dado es primo o no.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool primo = true;

            if (numero <= 1)
            {
                primo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            if (primo)
            {
                Console.WriteLine(numero + " es un número primo.");
            }
            else
            {
                Console.WriteLine(numero + " no es un número primo.");
            }

            Console.ReadKey();

        }
    }
}

