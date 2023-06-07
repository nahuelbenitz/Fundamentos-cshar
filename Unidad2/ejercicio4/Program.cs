namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una casa de computación paga a sus empleados un sueldo fijo 
            //de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
            //Hacer un programa para ingresar el total facturado por un empleado y que luego calcule 
            //y emita por pantalla el sueldo total a cobrar por el mismo.

            int sueldo;
            double facturado, comision, sueldoTotal;

            Console.WriteLine("Ingrese el total facturado por el empleado: ");
            facturado = double.Parse(Console.ReadLine());

            sueldo = 15000;
            comision = facturado * 0.05;
            sueldoTotal = sueldo + comision;

            Console.WriteLine("El total a cobrar por su empleado es: " + sueldoTotal);
            
        }
    }

}