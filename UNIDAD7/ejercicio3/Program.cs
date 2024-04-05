using System;
/* Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos 
(tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer 
carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla.
Ejemplo:
CADENA FUENTE: “La mar estaba serena"
CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
CADENA RESULTADO: “Li mir estibi sereni" */

namespace ejercicio3
{
    class Program
    {
        static void Main(string[]args)
        {
            char letra1, letra2;
            char[] frase = new char[30]; 
            int indice= 0;
            char letra;
            Console.WriteLine("INGRESE UNA LETRA: ");
            letra =char.Parse(Console.ReadLine());

            while(letra != '0'&& indice <30)
            {
                frase[indice]= letra;
                indice++;
                Console.WriteLine("INGRESE OTRA LETRA: ");
                letra =char.Parse(Console.ReadLine());
            }
            frase[indice]='\0';
            
            Console.WriteLine("LA FRASE COMPLETA ES : ");
            indice=0;
            while(frase[indice]!= '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
            Console.WriteLine("");
            Console.WriteLine("INGRESE LA LETRA QUE QUIERA REEMPLAZAR : ");
            letra1=char.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA NUEVA LETRA : ");
            letra2=char.Parse(Console.ReadLine());
            indice=0;
            while(frase[indice]!='\0')
            {
                if(frase[indice]== letra1)
                {
                    frase[indice]=letra2;
                }
                indice++;
            }
            Console.WriteLine("LA FRASE NUEVA ES : ");
            indice=0;
            while(frase[indice]!= '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
        }
    }
}
