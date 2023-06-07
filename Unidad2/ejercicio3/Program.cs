namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades 
            //y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo 
            //aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

            double dis, vel, tiempo;

            Console.WriteLine("Bienvenido a la calculadora de distancia");

            Console.WriteLine("Por favor, ingrese la distancia de su destino: ");
            dis = double.Parse(Console.ReadLine());
             
            Console.WriteLine("Por favor, ingrese la velocidad en la que se desplaza: ");
            vel = double.Parse(Console.ReadLine());

            tiempo = dis / vel;

            Console.WriteLine("Usted llegara en " + tiempo + " horas");

            
        }
    }

}


