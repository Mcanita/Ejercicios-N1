using System;
// Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada 
// según los siguientes valores:

// Si el importe es menor a ARS 1000, no hay descuento.
// Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
// Si el importe es ARS 5000 o más, aplica un descuento del 18%.
// Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe
// final con el descuento que corresponda.

namespace ejer3
{
    class Program
    {
        static void Main(string[]args)
        {
            float ventas,total;
            float descuento;
            Console.WriteLine("INGRESE EL IMPORTE DE LA VENTA : ");
            ventas=float.Parse(Console.ReadLine());
            if(ventas<1000)
            {
                Console.WriteLine("EL TOTAL A PAGAR ES : "+ventas.ToString("0.00"));
            }
            if(ventas>=1000 && ventas <5000)
            {
                descuento = ventas * 0.10F ;
                total = ventas - descuento;
                Console.WriteLine("EL TOTAL A PAGAR ES : "+total.ToString("0.00"));
            }
            if(ventas >=5000)
            {
                descuento = ventas * 0.18F ;
                total = ventas - descuento ;
                Console.WriteLine("EL TOTAL A PAGAR ES : "+total.ToString("0.00"));


            }
        }
    }
}
