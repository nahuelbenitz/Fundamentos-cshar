using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND y OR ...... NOT
            //AND [y] Operador: &&
            //OR [o] Operador: ||
            //NOT [no] Operador: !
            //valor OP valor AND valor OP valor
            //valor OP valor OR valor OP valor

            int edad = 20;
            char inicial = 'J';

            //true && true
            if(edad > 20 && inicial == 'J'){
                Console.WriteLine("21 OFF...");
            }

            //OR
            //true || true = true
            //false || true = true
            //true || false = true
            //false || false = false

            //AND
            //true && true = true
            //false && true = false
            //true && false = false
            //false && false = false

            //-----------------------------------------------------------------------------------------------------

            //Switch

            char letra = 'A';
            
            switch(letra){
                case 'M':
                    //lalalaal
                    //lalalal
                    break;
                case 'H':
                    //lalalal
                    //lalalal
                    break;
                case 'R':
                    //lalalal
                    //lalala
                    break;
                default:
                    //no coincide con ninguna
                    break;
            }




        }
    }
}
