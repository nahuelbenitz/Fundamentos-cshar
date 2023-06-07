using System;

namespace ejercicio2
{
    class Program{

        static void Main(string[] args)
        {
            //2. Hacer un programa para solicitar por teclado un número y 
            //luego devolver su valor elevado al cubo.

            int num, resultado;

            Console.WriteLine("Bienvenido a la calculadora al cubo");
            Console.WriteLine("Por favor, ingrese el número a elevar: ");
            num = int.Parse(Console.ReadLine());
            
            resultado = num * num * num;

            Console.WriteLine("El resultado es: " + resultado);

        }

    }

}