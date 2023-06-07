using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
            
            int num1, num2, resultado;

            Console.WriteLine("Bienvenido a las sumas");

            Console.WriteLine("Por favor, ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ahora ingrese el segundo número: ");           
            num2 = int.Parse(Console.ReadLine());
            
            resultado = num1+num2;

            Console.WriteLine("El resultado de su suma es: " + resultado);           
            Console.WriteLine("Gracias por usarme");           

 
        }

    }
}



