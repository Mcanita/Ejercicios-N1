using System;

// Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la 
// velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que
// demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

namespace ej3
{
    class Program
    {
        static void Main(string[]args)
        {
            float km,vel,tiempo;
            Console.WriteLine("INGRESE LA CANTIDAD DE KILOMETROS : ");
            km=float.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA VELOCIDAD PROMEDIO : ");
            vel=float.Parse(Console.ReadLine());
            tiempo=km/vel;
            Console.WriteLine("EL TIEMPO APROXIMADO ES DE  "+tiempo.ToString("0.0"));
        }
    }
}