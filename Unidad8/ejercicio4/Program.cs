using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y 
            //una variable por referencia. Que analice el número y escriba la variable recibida por referencia con:
            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.

            int numero, estado = 2;
            Console.WriteLine("Bienvenido, si al finalizar el estado de su numero es 1, es positivo. Si es 0, es cero. Y si es -1, es negaivo");
            Console.WriteLine("Ingrese un numero ");
            numero = int.Parse(Console.ReadLine());

            //llamo a mi funcion y le doy el numero por valor y el estado por referencia (me puede modificar esta ultima)
            positivoNegativoCero(numero, ref estado);

            Console.WriteLine("El numero ingresado esta en " + estado);
        }

        static void positivoNegativoCero(int a, ref int b){
            //analizo si mi numero es positivo o negativo y en caso que ambas sean falsas significa que es cero. Dependiendo el resultad, asigno a mi variable estado
            if (a > 0){
                b = 1;
            } 
            else if(a < 0){
                b = -1;
            } 
            else{
                b = 0;
            }
        }
    }
}
