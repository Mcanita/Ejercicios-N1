using System;
// Hacer un programa que solicite el ingreso de dos números y luego calcular:

// La resta si el primero es mayor que el segundo.
// La suma si son iguales.
// El producto si el primero es menor.
// Se deberá emitir un cartel por pantalla con el resultado correspondiente.

namespace e1
{
    class Program
    {
        static void Main(string[]args)
        {
            int n1,n2,resultado;
            Console.WriteLine("INGRESE EL PRIMER NÚMERO : ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SEGUNDO NÚMERO : ");
            n2 = int.Parse(Console.ReadLine());

            if(n1<n2)
            {
                resultado = n1*n2;
                Console.WriteLine("EL RESULTADO DE LA MULTIPLICACION ES : "+resultado);
            }
            if(n1==n2)
            {
                resultado = n1+n2;
                Console.WriteLine("EL RESULTADO DE LA SUMA ES : "+resultado);
            }
            if(n1>n2)
            {
                resultado = n1-n2;
                Console.WriteLine("EL RESULTADO DE LA RESTA ES : "+resultado);
            }

          
        }
    }
}
