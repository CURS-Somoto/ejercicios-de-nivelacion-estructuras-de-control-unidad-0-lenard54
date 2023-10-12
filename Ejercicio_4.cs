/*Ejercicio 4: Serie factorial


Crea un programa que genere y muestre el
resultado factorial de un numero. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero");

            int multiplicacion = 1;
            int numero = Convert.ToInt32(Console.ReadLine());

            while (numero > 0)
            {
                multiplicacion = multiplicacion * numero;
                numero--;
              //Console.WriteLine() lo escribi dentro del metodo para ver todos los resultados
                Console.WriteLine(multiplicacion);
            }
           //Pero se que si lo escribo afuera solamente va a imprimir el ultimo resultado del bucle.
            Console.ReadKey();
        }
    }
}

