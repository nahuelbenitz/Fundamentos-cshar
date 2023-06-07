using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. El mismo debe analizar 
            //y mostrar por pantalla cuántos de esos números son primos.


            int num, con = 0, conPrimos = 0;

            for (int x = 0; x < 10; x++)
            {
                //pido el numero
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                //inicio la variable para la siguiente vuelta del ciclo
                con = 0;
                
                //analizo si el numero es primo dividiendolo por todos los numeros de 1 a n
                for (int y = 1; y <= num; y++) {

                    if (num % y == 0) {
                        con++;
                    }
                    
                }
                //si es primo, sumo uno
                if (con == 2) {
                    conPrimos++;
                }
  
            }
            //muestro el conteo final de los primos
            Console.WriteLine("En total ingresaste " + conPrimos + " numeros primos");
        }
    }
}
