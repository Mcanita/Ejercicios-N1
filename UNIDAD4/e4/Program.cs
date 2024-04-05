using System;

// Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma 
// de los dos primeros es mayor al producto del segundo con el tercero.

namespace e4
{
    class Program
    {
        static void Main(string[]args)
        {
            int n1, n2, n3, suma, producto, mayor;
            Console.WriteLine("INGRESE UN NÚMERO : ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NÚMERO : ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL TERCER NÚMERO : ");
            n3 = int.Parse(Console.ReadLine());

            suma = n1+n2;
            producto = n2*n3;
            if(suma>producto){
                Console.WriteLine("LS SUMA DE LOS DOS PRIMEROS ES MAYOR AL PRODUCTO DEL SEGUNDO Y TERCERO ");
                Console.WriteLine("SUMA : "+suma+" PRODUCTO : "+producto);
            }
            else{
                Console.WriteLine("EL PRODUCTO ES MAYOR QUE LA SUMA ");
                Console.WriteLine("SUMA : "+suma+" PRODUCTO : "+producto);
            }
        }
    }
}