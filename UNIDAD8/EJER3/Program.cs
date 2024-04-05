using System;
/* Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es
primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se
ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos */

namespace EJER3
{
    class Program
    {
        static void Main(string[]args)
        {
            int num,respuesta;
            int cont=0,acum=0;
            int prom;

            Console.WriteLine("INGRESE UN NRO : ");
            num = int.Parse(Console.ReadLine());
            while (num !=0)
            {
                respuesta = primo(num);
                if (respuesta==1)
                {
                    cont++;
                    acum+=num;
                }
                Console.WriteLine("INGRESE UN NRO : ");
                num = int.Parse(Console.ReadLine());
                
            }
            prom= acum/cont;
            Console.WriteLine("EL PROMEDIO DE LOS NROS PRIMOS ES DE : "+prom);
            
        }
        static int primo (int x)
        {
            int cont=0;
            for (int i = 1; i < x; i++)
            {
                if (x % i ==0)
                {
                    cont++;
                }
            }
            if (cont ==1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
