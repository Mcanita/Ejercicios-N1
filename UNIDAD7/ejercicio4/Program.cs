using System;
/*  Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro 
con los siguientes datos:
- Número de Artículo (1 a 15)
- Cantidad Vendida 

Puede haber varios registros para el mismo artículo y el último se indica con número de artículo 
igual a 0.
Se pide determinar e informar:
a) El número de artículo que más se vendió en total.
b) Los números de artículos que no registraron ventas.
c) Cuantas unidades se vendieron del número de artículo 10.*/

namespace ejercicio4
{
    class Program
    {
        static void Main(string[]args)
        {
            int articulo,cont=0;
            int cantidad;
            int maxCantidad, nroArt=1;
            int [] TotalVentas = new int [15];

            for (int i = 0; i < 15; i++)
            {
                TotalVentas[i]=0;
            }

            Console.WriteLine("INGRESE EL NRO DE ARTICULO : ");
            articulo= int.Parse(Console.ReadLine());

            while(articulo!=0)
            {
                Console.WriteLine("INGRESE CANTIDAD VENDIDA : ");
                cantidad = int.Parse(Console.ReadLine());
                TotalVentas[articulo-1]+=cantidad;
                Console.WriteLine("INGRESE EL NRO DE ARTICULO : ");
                articulo= int.Parse(Console.ReadLine());
                
            }
            
            maxCantidad= TotalVentas[0];
            for (int i = 0; i < 15; i++)
            {
                if(TotalVentas[i]> maxCantidad)
                {
                    maxCantidad=TotalVentas[i];
                    nroArt= i+1;
                }
            }
            Console.WriteLine("EL ARTICULO MAS VENDIDO ES : "+nroArt);
            Console.WriteLine("CON LA CANTIDAD DE : "+ maxCantidad);
            Console.WriteLine("");
            Console.WriteLine("DEL ARTICULO 10 SE VENDIERON : "+TotalVentas[9]+" ARTICULOS ");

            for (int i = 0; i < 15; i++)
            {
                if(TotalVentas[i]==0)
                {
                    Console.WriteLine("EL ARTICULO : "+(i+1)+" NO REGISTRA VENTAS ");
                }
            }
        }
    }
}
