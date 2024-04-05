using System;
// Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego 
// recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son
// mayores al promedio.

namespace ejercicio2 
{
    class Program 
    {
        static void Main(string[]args)
        {
            int[] numeros = new int [5];
            int  acum=0 ,prom=0;
            for(int i =0; i<5;i++)
            {
                Console.WriteLine("INGRESE UN NRO : ");
                numeros[i]= int.Parse(Console.ReadLine());
                
                acum+= numeros[i];
                Console.WriteLine(" ");
            }
            prom= acum / 5;
            Console.WriteLine("EL PROM ES : "+prom);
            for(int i=0; i<5;i++)
            {
                if(prom<numeros[i])
                {
                    Console.WriteLine("EL NRO "+ numeros[i]+" ES MAYOR AL PROMEDIO ");
                }
            }
        }
    }
}
