/*Ejercicio 2: Suma de Dígitos


Crea un programa que calcule y muestre la
suma de los dígitos de un número ingresado por el usuario.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int suma = 0;

            while (numero != 0) 
            {
                int digito = numero % 10;
                suma += digito;
                numero /= 10;
            }

            Console.WriteLine("La suma de los digitos es: " + suma);

            Console.ReadLine();
        }
    }
}
