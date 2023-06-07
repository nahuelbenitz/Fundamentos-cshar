using System;

namespace TPFinal_Benitez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.
            //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int n, indice = 0, mayorPar = 0, contImpar = 0, menorPrimo = 0;            //inicializo en cero porque sino me da error
            bool banPar = false, banPrimo = false;

            Console.WriteLine("Ingrese un '1' para comenzar: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0) 
            {
                Console.WriteLine("Ingrese un numero. (Recuerde que para cortar debe ingresar 0)");
                n = int.Parse(Console.ReadLine());
                
                //utilizo el concepto de bandera para saber cual es el primer numero par ingresado y luego comparo este con los siguiente numeros que se ingresen. 
                //Si el nuevo es mayor, pasa a ser mayorPar
                if (n % 2 == 0) 
                {
                    if (banPar == false) 
                    {
                        mayorPar = n;
                        banPar = true;
                    } 
                    else if (n > mayorPar) 
                    {
                        mayorPar = n;
                    }
                }
                //en caso que el numero sea impar, incremento el contador de impares
                else {
                    contImpar++;
                }

                //aplico la misma logica que usamos para saber si eran pares, pero para saber si son primos (llamamos a la función) y cual es el menor de estos
                if (primos(n))
                {
                    if (banPrimo == false) 
                    {
                        menorPrimo = n;
                        banPrimo = true;
                    }
                    else if(n < menorPrimo)
                    {
                        menorPrimo = n;
                    }
                }
            
            
            }

            //Punto a
            Console.WriteLine("El mayor de los numeros pares fue el " + mayorPar);
            //Punto b
            Console.WriteLine("Se han ingresado " + contImpar + " numeros impares");
            //Punto c
            Console.WriteLine("El menor de los numeros primos ingresados es el " + menorPrimo);


        }


        //Función primos
        static bool primos(int a){
             int con = 0;
            
            //creo un for que de tantas vueltas como el numero ingresado
            for (int x = 1; x <= a; x++) 
            {

                //veo cuantos divisores tiene mi numero para determinar si es primo
                if (a % x == 0)
                    con++;

            }

            //analizo las vueltas y asigno 'True' si es primo o 'False' si no lo es
            if (con == 2)
                return true;
            else
                return false;

        }
    }
}
