using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa para recibir listas de números positivos que están separadas entre 
            //sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar
            // cuántos números tiene cada lista.
            
            int n, con = 0, lista = 0;

            Console.WriteLine("Ingrese 1 para iniciar su lista");
            n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese su lista de numeros, para finalizarla ingrese 0 y para concluir el programa ingrese -1");
            while (n >= 0)
            {
                
                n = int.Parse(Console.ReadLine());

                //reinicio el contador y guardo el numero de lista actual
                con = 0;
                lista++;
                while (n > 0)
                {
                    con++;
                    n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("En la lista " + lista + " ingreso " + con + " numeros positivos");

            }

            Console.WriteLine("Gracias por usarme. Fin del programa");
        }
    }
}
