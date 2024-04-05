using System;
// Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles
// son mayores a 100.
namespace ejer5
{
    class Program
    {
        static void Main(string[]args)
        {    
            int n1,n2,n3,n4;

            Console.WriteLine("INGRESE EL PRIMER NÚMERO : ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NÚMERO : ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL TERCER NÚMERO : ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL ÚLTIMO NÚMERO : ");
            n4 = int.Parse(Console.ReadLine());

            if(n1>100)
            {
                Console.WriteLine("EL NÚMERO "+n1+" ES MAYOR A 100 ");
            }

            if(n2>100)
            {
                Console.WriteLine("EL NÚMERO "+n2+" ES MAYOR A 100 ");
            }

            if(n3>100)
            {
                Console.WriteLine("EL NÚMERO "+n3+" ES MAYOR A 100 ");
            }

            if(n4>100)
            {
                Console.WriteLine("EL NÚMERO "+n4+" ES MAYOR A 100 ");
            }

        }
    }
}
