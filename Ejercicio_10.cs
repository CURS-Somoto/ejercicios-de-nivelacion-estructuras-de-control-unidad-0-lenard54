/*
Ejercicio 10: Determinar si un Número es
Positivo, Negativo o Cero


Escribe un programa en C# que determine si
un número entero dado es positivo, negativo o cero.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinar_negatio_positivo_o_cero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdusca un numero");

           int numero = Convert.ToInt32(Console.ReadLine());

           if (numero > 0) 
           {
               Console.WriteLine(" Es positivo");
           }
           else if (numero == 0) {
               Console.WriteLine("Es cero");
           }
           else{
               Console.WriteLine("Es negativo");
           }
          
           Console.ReadKey();
           }
      }
}
