using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
            //de la cantidad de litros vendidos según la siguiente escala:
                //Si vende menos de 100 litros, no hay descuento.
                //Si vende entre 101 y 300 litros, el descuento es del 10%.
                //Si vende entre 301 y 500 litros, el descuento es del 15%.
                //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y 
            //la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

            double litros, importe, importeFinal;

            Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
            litros = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total abonado: ");
            importe = double.Parse(Console.ReadLine());

            if(litros > 500){
                importeFinal = importe * 0.75;
                Console.WriteLine("El total a abonar con el descuento aplicado es: " + importeFinal);
            }
            else if(litros > 300){
                importeFinal = importe * 0.85;
                Console.WriteLine("El total a abonar con el descuento aplicado es: " + importeFinal);
            }
            else if(litros > 100){
                importeFinal = importe * 0.90;
                Console.WriteLine("El total a abonar con el descuento aplicado es: " + importeFinal);
            }
            else{
                importeFinal = importe;
                Console.WriteLine("El total a abonar no tiene descuento, asi que es: " + importeFinal);
            }


        }
    }
}
