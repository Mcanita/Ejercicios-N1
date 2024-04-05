using System;

//Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

namespace ej1
{
    class Program
    {
        static void Main(string[]args)
        {
            int n1,n2,suma;

            Console.WriteLine("INGRESE EL PRIMER NÚMERO : ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NÚMERO : ");
            n2=int.Parse(Console.ReadLine());
            suma=n1+n2;

            Console.WriteLine("LA SUMA ES : "+suma);
        }
    }
}