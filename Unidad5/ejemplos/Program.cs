using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //----aca codigo----
            //CICLO FOR
            //----aca codigo----
            //  for(int x = 0; x < 5; x++){
            //      Console.WriteLine("Hola mundo" + x);
            //      ---más codigo---
            //}
            //----mas codigo----

            int n = 0, promedio, suma = 0;
            

            for (int x = 0; x < 5; x++) {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
                suma += n;
            }

            promedio = suma / 5;

            Console.WriteLine("El promedio es: " + promedio);

            //--------------------------------------

            //CICLO WHILE

            int m, cont = 0;

            
            Console.WriteLine("Ingrese un numero");
            m = int.Parse(Console.ReadLine());

            while (m != 0) { 
                cont++;
                Console.WriteLine("Ingrese un numero");
                m = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingresaste: " + cont + " numeros.");

            //---------------------------------------------------

            //CICLO DO WHILE

            int a;

            do{
                Console.WriteLine("Ingrese un numero");
                m = int.Parse(Console.ReadLine());
            } while(n != 0);




        }
    }
}
