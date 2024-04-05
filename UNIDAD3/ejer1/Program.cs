using System;

// Hacer un programa para ingresar un número y luego se emita por pantalla un cartel 
// aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
namespace ejer1
{
    class Program
    {
       static void Main(string[]args)
        {
            int num;

            Console.WriteLine("INGRESE UN NÚMERO : ");
            num = int.Parse(Console.ReadLine());
            if(num>10)
            {
                Console.WriteLine("EL NUMERO INGRESADO ES MAYOR A 10 ");
            }
            else
            {
                Console.WriteLine("EL NUMERO INGRESADO ES MENOR A 10 ");
            }
        }
    }
}