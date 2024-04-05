using System;
// Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de 
// ellos por pantalla. Solo se debe emitir UN valor por pantalla
namespace EJ2
{
    class Program
    {
        static void Main(string[]args)
        {
            int  i, num,con = 1 , mayor;
            Console.WriteLine("INGRESE UN NRO: ");
            num = int.Parse(Console.ReadLine());
            mayor = num;

            for(i = 1; i <10; i++)
            {
                Console.WriteLine("INGRESE UN NRO: ");
                num = int.Parse(Console.ReadLine());
                con++;
                if(num > mayor)
                {
                    mayor = num;
                }
            }
            Console.WriteLine("EL MAYOR NRO INGRESADO ES : "+mayor);
            Console.WriteLine("SE INGRESARON "+con+" NROS ");
        }
    }
}
