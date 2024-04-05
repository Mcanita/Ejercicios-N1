using System;
// Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de
// aquellas personas mayores a 18 años

namespace EJ3
{
    class Program
    {
        static void Main(string[]args)
        {
            int i,cont=0, edad, acum=0 ,prom;

            for(i=0;i<3;i++){
                Console.WriteLine("INGRESE LA EDAD : ");
                edad = int.Parse(Console.ReadLine());
                if(edad>=18){
                    acum = acum + edad ;
                    cont++;
                }
            }
            prom = acum/cont;
            Console.WriteLine("EL PROMEDIO DE EDAD DE LOS MAYORES DE 18 ES DE : "+prom);
        }
    }
}