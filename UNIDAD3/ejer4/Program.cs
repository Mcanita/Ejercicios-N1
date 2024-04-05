using System;
// Hacer un programa para ingresar cuatro números distintos y luego mostrar por
//  pantalla el menor de ellos.

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {  
            int i ,n1,n2,n3,n4,menor;

            Console.WriteLine("INGRESE EL PRIMER NÚMERO : ");
            n1 = int.Parse(Console.ReadLine());
            menor = n1;

            Console.WriteLine("INGRESE EL SEGNDO NÚMERO : ");
            n2 = int.Parse(Console.ReadLine());
            if(menor>n2)
            {
                menor = n2;
            }

            Console.WriteLine("INGRESE EL TERCER NÚMERO : ");
            n3 = int.Parse(Console.ReadLine());
            if(menor>n3)
            {
                menor = n3;
            }

            Console.WriteLine("INGRESE EL ULTIMO NÚMERO : ");
            n4 = int.Parse(Console.ReadLine());
            if(menor>n4)
            {
                menor = n4;
            }
            Console.WriteLine("EL MENOR NÚMERO INGRESADO ES : "+menor);
            
        }
    }
}
