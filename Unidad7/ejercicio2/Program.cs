using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer 
            //ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int n, acu = 0, promedio;
            int[] numeros = new int[10];

            //cargo mi vector
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            //acumulo para sacar el promedio
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }
            promedio = acu / 10;

            //pregunto que numero es mayor al promedio y lo muestro por pantalla
            Console.WriteLine("Los numeros mayores al promedio son: ");
            for (int x = 0; x < 10; x++)
            {
                if (numeros[x] > promedio)
                {
                    Console.WriteLine(numeros[x]);
                }
            }
        }
    }
}
