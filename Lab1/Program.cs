using Lab1;

class Program
{
    static void Main(string[] args)
    {
        CajeroAutomatico cajero = new CajeroAutomatico();
        cajero.NumeroCuenta = 123456;
        cajero.Nombre = "Ejemplo Usuario";
        cajero.Saldo = 1000;
        cajero.Pin = 1234;

        Console.WriteLine("¡Bienvenido al Cajero Automático!");
        Console.WriteLine("Por favor, ingrese su PIN:");

        int pinIngresado = int.Parse(Console.ReadLine());

        if (cajero.IngresarPin(pinIngresado))
        {
            Console.WriteLine("Acceso concedido.");
            Console.WriteLine("1. Mostrar saldo");
            Console.WriteLine("2. Depositar fondos");
            Console.WriteLine("3. Retirar fondos");
            Console.WriteLine("4. Cambiar PIN");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Saldo actual: " + cajero.MostrarSaldo());
                    break;
                case 2:
                    Console.Write("Ingrese la cantidad a depositar: ");
                    int cantidadDeposito = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nuevo saldo: " + cajero.DepositarFondos(cantidadDeposito));
                    break;
                case 3:
                    Console.Write("Ingrese la cantidad a retirar: ");
                    int cantidadRetiro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nuevo saldo: " + cajero.Retirar(cantidadRetiro));
                    break;
                case 4:
                    Console.Write("Ingrese su nuevo PIN: ");
                    int nuevoPin = int.Parse(Console.ReadLine());
                    cajero.CambiarPin(nuevoPin);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Acceso denegado.");
        }
    }
}
