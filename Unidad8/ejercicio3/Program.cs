using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

            int n = 1, resultado;
            double promedio, acu = 0, cont = 0;

            //ingreso un lote de numeros hasta cortar con un '0'
            while (n != 0)
            {
                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());

                //llamo a mi funcion primo y guardo su return en mi variable resultado
                resultado = primo(n);

                //analizo si mi numero es primo, si es asi acumulo el número y cuento cuantos hay para luego sacar un promedio
                if (resultado == 1)
                {
                    acu += n;
                    cont++;
                }
            }

            promedio = acu / cont;

            Console.WriteLine("El promedio de los numeros primos ingresados es " + promedio);
        }


        //Función primo
        static int primo(int a){
            int r, con = 0;
            
            //creo un for que de tantas vueltas como el numero ingresado
            for (int x = 1; x <= a; x++)
            {
                //veo cuantas veces es divisble mi numero para determinar si es primo
                if (a % x == 0)
                {
                    con++;
                }
            }

            //analizo las vueltas y asigno 1 o 0 a r si es primo o no, respectivamente
            if (con == 2){
                r = 1;
            }
            else{
                r = 0;
            }

            return r;
        }
    }
}
