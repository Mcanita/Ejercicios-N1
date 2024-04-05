using System;
// Hacer un programa para solicitar por teclado un número y luego devolver 
// su valor elevado al cubo.
namespace ej2
{
    class Program
    {
        static void Main(string[]args)
        {
            int num,cubo;

            Console.WriteLine("INGRESE UN NÚMERO : ");
            num=int.Parse(Console.ReadLine());
            cubo=num*num*num;
            Console.WriteLine("EL CUBO DE "+num+" ES "+cubo);
        }
    }
}