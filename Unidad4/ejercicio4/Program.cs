using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la 
            //suma de los dos primeros es mayor al producto del segundo con el tercero.
            int n1, n2, n3, suma, producto;

            Console.WriteLine("Ingrese el primer número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            n3 = int.Parse(Console.ReadLine());

            suma = n1 + n2;
            producto = n2 * n3;

            if(suma > producto){
                Console.Write("La suma de los dos primeros es mayor al producto del segundo con el tercero");
            }
            
            Console.WriteLine("Fin del programa");





        }
    }
}
