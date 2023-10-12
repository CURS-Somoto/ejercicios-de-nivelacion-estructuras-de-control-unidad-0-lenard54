/* Ejercicio 8: Secuencia de Patrones


Desarrolla un programa que genere y muestre
la siguiente secuencia de patrones:


*


**


***


****


*****

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresion_de_patrones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                Console.WriteLine();  
               
            }
            
            Console.ReadKey();
        }
    }
}
