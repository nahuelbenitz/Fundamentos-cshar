using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //CICLOS COMBINADOS

            //For con For

            //int n, prom, acu, cont;

            // for (int x = 0; x < 10; x++)
            // {
            //     acu = 0;
            //     for (int y = 0; y < 20; y++)
            //     {
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     prom = acu / 20;
            //     Console.WriteLine("El promedio de edad es: " + prom);
            // }

            //For con While

            // for (int x = 0; x < 10; x++)
            // {   
            //     Console.WriteLine("Ingrese la edad: ");
            //     n = int.Parse(Console.ReadLine());
            //     acu = 0;
            //     cont = 0;
            //     while (n != 0) {
            //         acu += n;
            //         cont++;
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     prom = acu / cont;
            //     Console.WriteLine("El promedio de edad es: " + prom);
            // }

            //While con For

            // Console.WriteLine("Ingrese 1 para arrancar a procesar o 0 para terminar: ");
            // n = int.Parse(Console.ReadLine());
            // while(n != 0){
            //     acu = 0;
            //     for (int y = 0; y < 20; y++)
            //     {
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     prom = acu / 20;
            //     Console.WriteLine("El promedio de edad es: " + prom);
            //     Console.WriteLine("Ingrese 1 para continuar o 0 para terminar: ");
            //     n = int.Parse(Console.ReadLine());
            // }
            
            //While con While

            // Console.WriteLine("Ingrese la edad: ");
            // n = int.Parse(Console.ReadLine());
            // while(n > 0){

            //     Console.WriteLine("Ingrese la edad: ");
            //     n = int.Parse(Console.ReadLine());
            //     acu = 0;
            //     cont = 0;
            //     while (n != 0) {
            //         acu += n;
            //         cont++;
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     prom = acu / cont;
            //     Console.WriteLine("El promedio de edad es: " + prom);
                
            //     Console.WriteLine("Ingrese la edad para continuar o negativo para cortar: ");
            //     n = int.Parse(Console.ReadLine());
            // }
                
            //CORTE DE CONTROL
            //legajo, edad, sueldo, codigo de equipo

            int legajo, edad, CodigoEquipo;
            float sueldo;
            int equipoActual;

            Console.WriteLine("Ingrese el legajo");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de equipo numerico");
            CodigoEquipo = int.Parse(Console.ReadLine());

            while (sueldo > 0)
            {
                //asignamos ---> CORTE DE CONTROL <---
                equipoActual = CodigoEquipo;
                while (CodigoEquipo == equipoActual)
                {
                    //aca procesamos

                    Console.WriteLine("Ingrese el legajo");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el codigo de equipo numerico");
                    CodigoEquipo = int.Parse(Console.ReadLine());
                    //aca tambien se muestran resultados

                }
                //aca mostramos lo que nos pide
            }
            //aca tambien se muestran resultados
        }
    }
}
