/*
Ejercicio 9: Mayor de Dos Números


Dado dos números, muestra el número mayor
utilizando una estructura if

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el primer numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es " +numero1);
            }
            else if (numero1 < numero2) 
            {
                Console.WriteLine("El numero mayor es " +numero2);
            }
            else
            {
                Console.WriteLine("Los valores de los numeros deben de ser diferentes");
            }
            Console.ReadLine();
        }
    }
}
