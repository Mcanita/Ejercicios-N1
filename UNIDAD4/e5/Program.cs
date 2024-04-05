using System;

// Hacer un programa para ingresar 4 números. Luego analizar e informar por 
// pantalla si los mismos se encuentran ordenados de forma decreciente .

namespace e5
{
    class Program
    {
        static void Main(string[]args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("INGRESE EL PRIMER NÚMERO : ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NÚMERO : ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL TERCER NÚMERO : ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL CUARTO NÚMERO : ");
            n4 = int.Parse(Console.ReadLine());

            if(n1>n2 && n2>n3 && n3>n4)
            {
                Console.WriteLine("LOS NÚMEROS ESTAN EN FORMA DECRECIENTE");
            }
            else
            {
                Console.WriteLine("LOS NÚMEROS NO ESTÁN ORDENADOS ");
            }
        }
    }
}