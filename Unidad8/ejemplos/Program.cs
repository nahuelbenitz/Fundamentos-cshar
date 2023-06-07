using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES
            //PARTES DE LA FUNCIÓN
            //CABECERA
                //1. TIPO DE DATO
                //2. NOMBRE
                //3. Opcional: PARAMETROS
            //CUERPO
                //Definición/Logica
            //Opcional: Retorno de valor/resultado

            //-------------------------------------------------------------------
            //utilizo devolver uno
            Console.WriteLine("Fin del programa" + devolverUno());

            //-------------------------------------------------------------------
            //ejemplo funcion suma y cargar datos
            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);

            //lógica
            resultado = sumar(n1, n2);
            

            Console.WriteLine("El resultado es " + resultado);

            //-------------------------------------------------------------------
            //Pasar el argumento y recibir el parametro por valor, copia de la variable en memoria
            //Parametro por referencia, permite que la función le cambie el valor al argumento. Se utiliza 'ref'. Le envia la dirección en memoria, no hace una copia
        }

        //funcion devolver uno
        static int devolverUno(){
            int num = 1;
            return num;
        }

        //función lógica suma
        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
        }

        //función cargar datos
        static void pedirDatos(ref int j, ref int h){
            Console.WriteLine("Ingrese un numero: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            h = int.Parse(Console.ReadLine());
        }
    }
}
