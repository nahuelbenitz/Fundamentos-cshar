using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla 
            //el máximo de los números pares y el mínimo de los números impares.
            
            int num, max = 0, min = 0;
            bool banPar = false, banImpar = false;

            for (int x = 0; x < 20; x++)  {

                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                //trabajamos el concepto de bandera (si o no, verdadero o falso), puede ser 1, 2 o 3 tambien

                if (num % 2 == 0) {
                    if (banPar == false) {
                        max = num;
                        banPar = true;
                    } else if (num > max){
                        max = num;
                    }
                } else {
                    if (banImpar == false) {
                        min = num;
                        banImpar = true;
                    } else if (num < min){
                        min = num;
                    }

                }
                
                
            }

            Console.WriteLine("El minimo de los numeros impares es " + min);
            Console.WriteLine("El maximo de los numeros pares es " + max);
            
        }
    }
}
