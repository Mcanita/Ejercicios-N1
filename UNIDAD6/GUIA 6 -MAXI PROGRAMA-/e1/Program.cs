/* Se dispone de una lista de 10 grupos de números enteros separados entre ellos por ceros.
Se pide determinar e informar:
a. El número de grupo con mayor porcentaje de números impares positivos respecto al total de
números que forman el grupo.
b. Para cada grupo, el último número primo y en qué orden apareció en ese grupo. Si en un
grupo no hubiera números primos, informarlo con un cartel aclaratorio.
c. Informar cuántos grupos están formados por todos números ordenados de mayor a menor */

internal class Program
{
    private static void Main(string[] args)
    {
        int num, imparP=0, porcentajeI, cont=0, mayorP=0, pos=0;

        for (int i = 0; i < 3; i++)
        { 
            Console.WriteLine("GRUPO : "+(i+1));
             Console.WriteLine("INGRESE UN NRO : ");
             num= int.Parse(Console.ReadLine());
             cont++;
             if(num%2 !=0 && num> 0)
                imparP++;

             while(num !=0)
             {
                 Console.WriteLine("INGRESE UN NRO : ");
                num= int.Parse(Console.ReadLine());
                cont++;
                if(num%2 !=0 && num> 0)
                imparP++;
             }
             Console.WriteLine("numeros im pos : "+imparP);
             Console.WriteLine("total num : "+(cont-1));
             porcentajeI= (imparP*100)/(cont-1);
             Console.WriteLine("porcentaje i : "+ porcentajeI);
             imparP=0;
             cont=0;

             if(i==0)
             {
               mayorP= porcentajeI;
               pos= i;
             }
             else if (mayorP> porcentajeI)
             {
               porcentajeI= mayorP;
               pos= i;
             }
               
        }
        Console.WriteLine("EL GRUPO : " +(pos+1)+" TIENE EL MAYOR PORCENTAJE IMPARES POSITIVOS : "+mayorP);
       
    }
}