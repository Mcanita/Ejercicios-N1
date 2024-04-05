using System;
/* Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero
si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares */

namespace EJER2
{
    class Program
    {
        static void Main(string[]args)
        {
            int n ,j ,cont=0;
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("INGRESE UN NRO : ");
                n = int.Parse(Console.ReadLine());
                j = par(n);
                if(j==1)
                {
                    cont++;
                }
            }
            Console.WriteLine("HAY "+cont+" NROS PARES");
            
        }
        static int par(int x )
        {
            if(x % 2 ==0)
            {
                return 1;
            }
            else
            {
                return 0 ;
            }
        }
    }
}