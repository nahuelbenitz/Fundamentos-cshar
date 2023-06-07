using System;

namespace acu_con
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acumuladores y contadores
            int contador = 0;
            int acumulador = 0;

            contador = contador + 1;
            contador = contador + 1;

            acumulador = acumulador + 18;
            acumulador = acumulador + 22;

            //++
            //--
            contador++;

            //+=
            //-=
            acumulador += 5;

        }
    }
}
