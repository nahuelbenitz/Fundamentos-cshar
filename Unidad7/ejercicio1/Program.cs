using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer 
            //los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            //declaro mis variables y mi vector
            int n, pos = 0, max;
            int[] numeros = new int[10];

            //cargo mi vector
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            //analizo cual es el maximo y guardo su posicion
            max = numeros[0];
            pos = 1;

            
            for (int x = 0; x < 10; x++)
            {
                //si encuentro un numero mayor lo guardo junto a su posicion
                if (numeros[x] > max)
                {
                    max = numeros[x];
                    pos = x + 1;
                }
            }
            
            //muestro lo que me pide el ejercicio
            Console.WriteLine("El valor maximo esta en la posicion " + pos + " y es el numero " + max);
        }
    }
}
