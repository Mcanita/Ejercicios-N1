using System;

//  Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno
//  y luego calcule y emita por pantalla el promedio final.

namespace ej5
{
    class Program
    {
        static void Main(string[]args)
        {
            float nota1, nota2, nota3, prom;

            Console.WriteLine("INGRESE LA PRIMERA NOTA : ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA SEGUNDA NOTA : ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA TERCER NOTA : ");
            nota3 = float.Parse(Console.ReadLine());

            prom = (nota1 + nota2 + nota3) /3;

            Console.WriteLine("EL PROMEDIO ES DE : "+prom.ToString("0.00"));

        }
    }
}