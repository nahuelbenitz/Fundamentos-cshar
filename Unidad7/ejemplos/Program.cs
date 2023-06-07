using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //VECTORES. ARRAY. ARREGLO
            int n;
            int[] numeros = new int[10];

            //carga de vector manual
            numeros[6] = 1; 
            numeros[0] = 7; 
            numeros[9] = 32450;

            //carga de vector con for
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la nota");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            //ejemplo promedio usando for
            int acu = 0;

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }

            int promedio = acu/10; 

            //----------------------------------------------------------------------------------

            //VECTORES DOUBLE
            //int (long, short)
            //float - double - decimal
            double[] muestraMatutina = new double[31];
            double[] muestraVespertina = new double[31];
            double[] muestraNocturna = new double[31];

            //cruce
            //registro matutino
            int dia;
            double temperatura;
            Console.WriteLine("Cargue el registro matutino");
            for (int x = 0; x < 31; x++) {
                Console.WriteLine("Ingrese dia ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese temperatura ");
                temperatura = double.Parse(Console.ReadLine());

                //se usa el dia de indice y se le resta uno porque el vector va de 0 a 30 y dia de 1 a 31
                muestraMatutina[dia-1] = temperatura;
            }

            for (int x = 0; x < 31; x++) {
                
            }
            
            for (int x = 0; x < 31; x++) {
                
            }


            //leer vectores
            double acumu = 0;
            for (int x = 0; x < 31; x++)
            {
                acumu += muestraMatutina[x];
            }

            //ejemplo sueldo y legajo
            double[] sueldos = new double[50];
            int[] legajos = new int[50];

            for (int x = 0; x < 50; x++)
            {
                Console.WriteLine("Ingrese sueldo y legajo del trabajador");
                sueldos[x] = 123;
                legajos[x] = 12345;
            }

            //--------------------------------------------------------------------------------------

            //VECTOR BOOL
            //int, float, bool, char

            bool[] asistenciasQuincenal = new bool[15];
            for (int x = 0; x < 15; x++)
            {
                //dia
                //asistencia
            }

            //--------------------------------------------------------------------------------------------

            //CADENA DE CARACTERES
            char[] asistencias = new char[10];
            asistencias[0] = 'P'; 
            asistencias[1] = 'P'; 
            asistencias[2] = 'A'; 

            //STRING
            //CADENA DE CARACTERES
            //VECTOR DE CHAR

            //BARRA CERO
            //\0
            char[] frase = new char[10];
            frase[5] = '\0';

            char[] nombre = new char[11];

            char j, letra;
            j = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre letra por letra ");

            for (int x = 0; x < 10; x++)
            {
                
            }

            int indice = 0;

            Console.WriteLine("Ingrese su nombre letra por letra (termina con '0')");
            letra = char.Parse(Console.ReadLine());

            while (letra != '.' && indice < 10)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            
            // if (indice == 10)
            // {
            //     indice--;
            // }

            nombre[indice - 1] = '\0';

            //Console.WriteLine("Hola " + nombre);

            Console.Write("Hola ");
            indice = 0;
            while (nombre[indice] != '\0')
            {
                Console.Write(nombre[indice]);
                indice++;
            }

        }
    }
}
