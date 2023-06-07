using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            //declaración de variables e ingreso de datos
            int precio, cantidad, resultado;

            Console.WriteLine("Ingrese el precio del producto ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del producto ");
            cantidad = int.Parse(Console.ReadLine());

            //llamo a funcion producto y le paso los argumentos por valor, para que haga el calculo
            resultado = producto(precio, cantidad);

            Console.WriteLine("El total a pagar es " + resultado);
        }


        //FUNCIÓN PRODUCTO
        static int producto(int a, int b){
            int r;
            r = a * b;
            return r;
        }
    }
}
