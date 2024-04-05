using System;
// Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer 
// los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector

namespace ejercicio1
{
    class Program
    {
        static void Main(string[]args)
        {
            int[] numeros = new int [10];
            int n, max=0, pos=0;

            Console.WriteLine("INGRESE 10 NROS : ");
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("NUMERO "+(i+1)+" : ");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n ;
                if(i == 0)
                {
                    max = n;
                    pos = i;
                }
                else 
                {
                    if(max < n)
                    {
                        max=n;
                        pos=i;
                    }
                
                }
            }
            Console.WriteLine("");
            Console.WriteLine("EL VALOR MAXIMO ES : "+ max);
            Console.WriteLine("Y SE INGRESO EN LA POSICION : "+ (pos+1));
            
        }
    }
}
