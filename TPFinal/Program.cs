using System;

namespace TPFinal_DeBiase
{
    class Program
    {
        static void Main(string[] args)
        {
    // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un
    // cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos. 
    // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que 
    // devuelva true o false según corresponda.

    int num, mayorPar=0;
    int contImpar=0, menorPrimo=0, contPrimerPrimo=0;

    Console.WriteLine("INGRESE UN NRO : ");
    num = int.Parse(Console.ReadLine());
    while (num !=0)
    {
        if (num % 2 ==0)
        {
            if(mayorPar< num)
            mayorPar=num;
        }
        else
        {
            contImpar++;
        }

        if(primo(num))
        {   
            contPrimerPrimo++;
            if(contPrimerPrimo==1 )
                 menorPrimo = num;
            else if(menorPrimo> num)
                menorPrimo = num;
        }
        
        Console.WriteLine("INGRESE UN NRO : ");
        num = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("EL MAYOR NRO PAR ES : "+mayorPar);
    Console.WriteLine("SE INGRESARON : "+contImpar+" NROS IMPARES");
    Console.WriteLine("EL MENOR DE LOS NROS PRIMOS ES : "+ menorPrimo);
    
        }
        static bool primo (int n)
        {
            int cont=0;
            for (int i = 1; i <= n; i++)
            {
                 if (n % i ==0)
                 {
                    cont++;
                 }
            }
            if (cont ==2)
                return true ;
            else
                return false;
        }
    }
}
