using System;
/* Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto
    de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y
    muestre por pantalla el monto total a pagar. Usar la función.*/

namespace EJER1
{
    class Program
    {
        static void Main(string[]args)
        {
            int n1, n2, resultado;
            int precio, cantidad , total;

            Console.WriteLine("INGRESE UN NRO: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("IGRESE OTRO NRO : ");
            n2 = int.Parse(Console.ReadLine());
            resultado=producto( n1, n2);
            Console.WriteLine("EL PRODUCTO DE LOS NROS ES : "+resultado);
            Console.WriteLine("");
            Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO : ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA CANTIDAD VENDIDA : ");
            cantidad = int.Parse(Console.ReadLine());
            total = producto(precio, cantidad);
            Console.WriteLine("EL TOTAL A PAGAR ES : "+total);



        }
        static int producto (int a , int b )
        {
            int p ;
            p = a * b ;
            return p;
        }
    }   

}
