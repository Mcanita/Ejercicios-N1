using System;
/* Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero”
que reciba un número por valor y una variable por referencia. Que analice el número y escriba
variable recibida por referencia con:

a. 1 si el número es positivo.
b. -1 si el número es negativo.
c. 0 si el número es cero. */

namespace EJER4
{
    class Program
    {
        static void Main(string[]args)
        {
            int num, valor=9;
            Console.WriteLine("INGRESE UN NRO : ");
            num = int.Parse(Console.ReadLine());
            positivoNegativoCero(num,ref valor);
            Console.WriteLine(valor);
        }
        static void positivoNegativoCero(int x , ref int j)
        {
            if(x > 0)
                j = 1;
            else if(x == 0)
                j= 0;
            else
                j = -1;
            
        }
    }
}
