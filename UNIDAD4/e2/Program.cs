using System;
// Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la 
// cantidad de litros vendidos según la siguiente escala:

// Si vende menos de 100 litros, no hay descuento.
// Si vende entre 101 y 300 litros, el descuento es del 10%.
// Si vende entre 301 y 500 litros, el descuento es del 15%.
// Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
// Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad
// de litros vendidos y calcule y emita el importe con el descuento  aplicado..

namespace e2
{
    class Program
    {
        static void Main(string[]args)
        {
            int total, litros ;
            float final,descuento;
            Console.WriteLine("INGRESE EL IMPORTE TOTAL : ");
            total = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE CANTIDAD DE LITROS : ");
            litros = int.Parse(Console.ReadLine());

            if(litros<=100)
            {
                Console.WriteLine("NO HAY DESCUENTO ");
                Console.WriteLine("EL TOTAL A ABONAR ES : "+total);
            }

            if(litros>100 && litros<=300)
            {
                Console.WriteLine("TENES UN DESCUENTO DEL 10% ");
                descuento = total *0.10F;
                final = total - descuento;
                Console.WriteLine("EL TOTAL A ABONAR ES : "+final.ToString("0.00"));
            }

            if(litros>300 && litros<=500)
            {
                Console.WriteLine("TENES UN DESUENTO DEL 15% ");
                descuento = total *0.15F;
                final = total-descuento;
                Console.WriteLine("EL IMPORTE A ABONAR ES : "+final.ToString("0.00"));
            }
            if(litros>500)
            {
                Console.WriteLine("TENES UN DESCUENTO DEL 25% ");
                descuento = total *0.25F;
                final = total - descuento;
                Console.WriteLine("EL IMPORTE A ABONAR ES : "+final.ToString("0.00"));
            }
        }
    }
}
