using System;
// Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio
// si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente
// por 1 y por sí mismo.

namespace EJ4
{
    class Program
    {
        static void Main(string[]args)
        {
            int i ,n ,cont=0;
            Console.WriteLine("INGRESE UN NÚMERO : ");
            n = int.Parse(Console.ReadLine());

            for(i=1 ;i<=n;i++){
                if(n % i ==0){
                    cont++;
                }
            }
            
            if(cont ==2){
                Console.WriteLine("ES PRIMO ");
            }
            else{
                Console.WriteLine("NO ES PRIMO ");
            }

        }
    }
}
