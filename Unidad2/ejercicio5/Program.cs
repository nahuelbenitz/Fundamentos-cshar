using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de 
            //un alumno y luego calcule y emita por pantalla el promedio final.

            int nota1, nota2, nota3, prom;

            Console.WriteLine("Ingrese la 1er nota del alumno: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la 2da nota del alumno: ");
            nota2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese la 3ra nota del alumno: ");
            nota3 = int.Parse(Console.ReadLine());
            

            prom = (nota1+nota2+nota3)/3;

            Console.WriteLine("El promedio del alumno es: " + prom);




        }
    }
}
