using System;

// Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una 
// comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar
// el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total 
// a cobrar por el mismo.

namespace ej4
{
    class Program
    {
        static void Main(string[]args)
        {
            int sueldo = 15000;
            float totalF, comision, cobra;
            Console.WriteLine("INGRESE EL TOTAL FACTURADO : ");
            totalF = float.Parse(Console.ReadLine());
            comision = totalF * 0.05F;
            cobra = sueldo + comision;
            Console.WriteLine("EL SUELDO A COBRAR ES DE : "+cobra.ToString("0.00"));
            
        }
    }
}