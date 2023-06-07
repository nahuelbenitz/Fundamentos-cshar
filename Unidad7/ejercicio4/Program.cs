using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:

                //- Número de Artículo (1 a 15)
                //- Cantidad Vendida

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:

            //a) El número de artículo que más se vendió en total.

            //b) Los números de artículos que no registraron ventas.

            //c) Cuantas unidades se vendieron del número de artículo 10.

            //Declaro mis variables y mi vector. A este ultimo lo inicializo en 0
            int numArticulo, cantidad;
            int[] totalCantidadVendida = new int[15];

            for (int x = 0; x < 15; x++)
            {
                totalCantidadVendida[x] = 0;

            }

            //completo mi vector con el total de cantidad vendida. El numero de producto me indica mi indice y guarda el total vendido de ese producto
            Console.WriteLine("Ingrese el numero de articulo: ");
            numArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            while (numArticulo != 0)
            {
                totalCantidadVendida[numArticulo - 1] += cantidad;

                Console.WriteLine("Ingrese el numero de articulo: ");
                numArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad vendida: ");
                cantidad = int.Parse(Console.ReadLine());
            }

            //punto a
            //el primer numero va a ser la cantidad maxima vendida
            int maxCantidad = totalCantidadVendida[0];
            int numMaximo = 1;
            
            //veo que producto es el que mas se vendio comparandolo con el primero
            for (int x = 0; x < 15; x++)
            {
                if (totalCantidadVendida[x] > maxCantidad)
                {
                    maxCantidad = totalCantidadVendida[x];
                    numMaximo = x + 1;
                }
            }

            Console.WriteLine("El producto más vendido es el " + numMaximo + " con la cantidad de " + maxCantidad);

            //punto b
            //analizo que lugar del array no acumulo ventas y lo muestro
            for (int x = 0; x < 15; x++)
            {
                if (totalCantidadVendida[x] == 0)
                {
                    Console.WriteLine("El producto " + (x + 1) + " no tiene ventas");
                }
            }

            //punto c

            Console.WriteLine("Del articulo 10, se vendieron " + totalCantidadVendida[9] + " productos");
        }
    }
}
