using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos 
            //por ceros. Se pide determinar e informar:
                //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
                //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, contNumeros = 0, contImpares = 0, grupoImparMax = 0, minimo, contOrdenados = 0;
            double porcentajeImpares, porcentajeMaximo = -1;
            bool banderaOrdenados;

            Console.WriteLine("Ingrese 1 para iniciar");
            n = int.Parse(Console.ReadLine());

            for(int x = 1; x <= 5; x++)
            {
                //inicio el programa
                Console.WriteLine("Usted esta en el grupo " + x);
                Console.WriteLine("Ingrese su lista y presione 0 para finalizar ");
                n = int.Parse(Console.ReadLine());
                
                //reincio mis contadores ya que trabajan por lista
                contNumeros = 0;
                contImpares = 0;
                banderaOrdenados = true;
                minimo = n;

                while (n != 0)
                {
                    contNumeros++;
                    //veo si son impares y cuento, despues cuento todo numero ingresado
                    if (n % 2 != 0)
                    {
                        contImpares++;
                    }
                    
                    //Punto b
                    //analizo si los grupos estan ordenados
                    if (n <= minimo)
                    {
                        minimo = n;
                    } 
                    else
                    {
                        banderaOrdenados = false;
                    }
                    
                    n = int.Parse(Console.ReadLine());
                }

                //aca saco el porcentaje de impares
                porcentajeImpares = (contImpares * 100) / contNumeros;

                //aca determino que grupo tiene el mayor porcentaje de impares
                if (porcentajeImpares > porcentajeMaximo) 
                {
                    porcentajeMaximo = porcentajeImpares;
                    grupoImparMax = x + 1;
                }

                //punto b
                //cuento cuantos grupos estan ordenados
                if (banderaOrdenados)
                {
                    contOrdenados++;
                }

                


            }

            Console.WriteLine("El grupo con mayor porcentaje de impares es " + grupoImparMax);
            Console.WriteLine("La cantidad de grupos con numeros ordenados es " + contOrdenados);
        }
    }
}
