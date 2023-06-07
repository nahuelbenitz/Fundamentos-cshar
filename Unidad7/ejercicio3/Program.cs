using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
            //sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:

                //CADENA FUENTE: “La mar estaba serena"

                //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’

                //CADENA RESULTADO: “Li mir estibi sereni"
            
            //Declaro mis variables y mi vector
            int indice = 0;
            char letra, a, b;
            char[] frase = new char[16];

            //Completo mi cadena de caracteres
            Console.WriteLine("Ingrese su frase letra por letra (termina con '0')");
            letra = char.Parse(Console.ReadLine());

            while (letra != '0' && indice < 16)
            {
                frase[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            //una vez que sale del ciclo (ingreso '.' o indice = 16) en la posicion indice corta con un '\0'
            frase[indice] = '\0';

            //Muestro la frase original
            Console.Write("La frase original es: ");
            indice = 0;
            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }

            //Pido los valores a y b
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese el primer caracter: ");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo caracter: ");
            b = char.Parse(Console.ReadLine());

            //analizo cuando aparece a y lo remplazo por b
            while(frase[indice] != '\0')
            {
                if (frase[indice] == a)
                {
                    frase[indice] = b;
                }
                indice++;
            }

            //Muestro la frase modificada con las variables a y b
            Console.Write("La frase modificada es: ");
            indice = 0;
            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }
        }
    }
}
