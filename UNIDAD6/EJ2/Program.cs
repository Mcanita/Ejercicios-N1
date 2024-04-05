using System;

// Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
// Se pide determinar e informar:

// El número de grupo con mayor porcentaje de números impares respecto al total de números que
// forman el grupo.
// Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

namespace EJ2
{
    class Program
    {
        static void Main(string[]args)
        {
            int num ,impar,total,grupo=0,mayor, norden,gruporden=0; 
            float porcentaje, mp = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("GRUPO NRO  : "+ (i+1));
                Console.WriteLine("INGRESE UN NRO : ");
                num = int.Parse(Console.ReadLine());
                mayor = num;
                impar = 0;
                total = 0;
                norden = 0;
                while (num !=0)
                {
                    total++;
                    
                    if(num %2 !=0)
                    {
                        impar++;
                    }
                    Console.WriteLine("INGRESE UN NRO : ");
                    num = int.Parse(Console.ReadLine());
                    if(mayor > num)
                    {
                        mayor = num;
                    }
                    else
                    {
                        norden++;
                    }
                }
                porcentaje = (impar * 100)/total;
                Console.WriteLine("EL PORCENTAJE DE IMPARES ES :  "+porcentaje.ToString("0.00")+" %");
                if(mp < porcentaje)
                {
                    mp = porcentaje;
                    grupo = i+1;
                }
                if(norden == 0)
                {
                    gruporden++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("EL GRUPO "+ grupo +" TIENE EL MAYOR % DE NROS IMPARES CON EL : "+mp+" % ");
            Console.WriteLine("HAY "+gruporden+" GRUPOS ORDENADOS DE MAYOR A MENOR");
            Console.WriteLine("");

        }
    }
}
