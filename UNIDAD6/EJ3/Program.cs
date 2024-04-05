using System;

// Hacer un programa para recibir listas de números positivos que están separadas entre 
// sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar
// cuántos números tiene cada lista.

namespace EJ3
{
    class Program
    {
        static void Main(string[]args)
        {
            int num, lista = 1,cant;
            Console.WriteLine("LISTA : "+(lista));
            Console.WriteLine("INGRESE UN NRO : ");
            num = int.Parse(Console.ReadLine());
            while (num >0)
            {
                cant = 0;
                while (num !=0)
                {
                    Console.WriteLine("INGRESE UN NRO : ");
                    num = int.Parse(Console.ReadLine());
                    cant++;
                }
                Console.WriteLine("LA LISTA "+lista+" TIENE "+cant+" NROS ");
                Console.WriteLine("");
                lista++;
                Console.WriteLine("LISTA : "+lista);
                Console.WriteLine("INGRESE UN NRO : ");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
