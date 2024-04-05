using System;

// Hacer un programa para ingresar 10 números. El mismo debe analizar y 
// mostrar por pantalla cuántos de esos números son primos

namespace EJ1
{
    class Program
    {
        static void Main(string[]args)
        {
            int num,cont, primo =0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("INGRESE UN NÚMERO : ");
                num = int.Parse(Console.ReadLine());
                cont = 0;

                for (int x = 1; x <= num; x++)
                {
                    if(num % x ==0)
                    {
                        cont++;
                    }
                }
                if(cont==2)
                    {
                        primo++;
                    }
                
            }
            Console.WriteLine("SE INGRESARON "+ primo +" NROS PRIMOS ");
            
        }
    }
}
