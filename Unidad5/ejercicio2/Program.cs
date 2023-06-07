using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de 
            //ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            
            int num, mayor = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                //para buscar el min cambio el signo > por <

                if (x == 0) {
                    mayor = num;
                }
                else if (num > mayor) {
                    mayor = num;
                }

            }

            Console.WriteLine("El mayor de los que ingreso es " + mayor);
        }
    }
}
