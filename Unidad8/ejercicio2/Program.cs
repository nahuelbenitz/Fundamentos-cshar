using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int n, resultado, cont = 0;

            //pido 20 numeros con un for
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
                //llamo a la funcion par y guardo su return en mi variable resultado
                resultado = par(n);

                //analizo si mi variable es 1 (par) y cuento cuantas veces lo fue
                if (resultado == 1)
                {
                    cont++;
                }
            }

            Console.WriteLine("En total hay " + cont + " numeros pares");
        }


        //Función par
        static int par(int a){
            int r;
            //veo si el resto de mi numero divido 2 da 0, y si es asi le asigno 1 a r, sino 0
            if (a % 2 == 0) {
                r = 1;
            } 
            else{
                r = 0;
            }
            //retorno r con el valor asignado
            return r;
        }
    }
}
