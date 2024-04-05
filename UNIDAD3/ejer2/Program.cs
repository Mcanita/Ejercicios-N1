using System;

// Hacer un programa para ingresar un número y luego se emita un cartel por pantalla
// “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o
// “Cero” si el número es igual a cero.

namespace ejer2
{
    class Program
    {
        static void Main (string[]args)
        {
            int num;
            Console.WriteLine("INGRESE UN NÚMERO : ");
            num = int.Parse(Console.ReadLine());
            if(num==0)
            {
                Console.WriteLine("EL NÚMERO ES 0 ");
            }

            if(num<0)
            {
                Console.WriteLine("EL NÚMERO ES NEGATIVO ");
            }

            if(num>0)
            {
                    Console.WriteLine("EL NÚMERO ES POSITIVO ");
            }
            }
            
        }
    }

