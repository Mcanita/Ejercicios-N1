using System;
// Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo
// de los números pares y el mínimo de los números impares.
namespace EJ5
{
    class Program
    {
        static void Main(string[]args)
        {
            int num, par=0, impar=0, max=0, min=0, i;

            for(i=0;i<6 ;i++){
                Console.WriteLine("INGRESE UN NRO : ");
                num = int.Parse(Console.ReadLine());
                if(num %2==0 ){
                    par++;
                    if(par==1){
                        max=num;
                    }
                    if(max < num){
                        max=num;
                    }
                }
                else{
                    impar++;
                    if(impar==1){
                        min=num;
                    }
                    if(min>num){
                        min=num;
                    }

                }
            }
            Console.WriteLine("EL MAYOR DE LOS N° PARES ES : "+max);
            Console.WriteLine("EL MENOR DE LOS N° IMPARES ES : "+min);
        }
    }
}
