using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos
            int n1, n2, n3, n4, menor;

            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el tercer numero");
            n3 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el cuarto numero");
            n4 = int.Parse(Console.ReadLine());

            menor = n1;

            if(menor > n2){
                menor = n2;
            }
            else if(menor > n3){
                menor = n3;
            }
            else if(menor > n4){
                menor = n4;
            }

            Console.WriteLine("El numero menor es: " + menor);

        }
    }
}
