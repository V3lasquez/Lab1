using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    using System;
    public class CuentaBancaria
    {
        public int NumeroCuenta { get; set; }
        public string Nombre { get; set; }
        public int Saldo { get; set; }
        public int Pin { get; set; }
    }

    public class CajeroAutomatico : CuentaBancaria
    {
        public double MostrarSaldo()
        {
            return Saldo;
        }

        public double DepositarFondos(int cantidad)
        {
            Saldo += cantidad;
            return Saldo;
        }

        public double Retirar(int cantidad)
        {
            try
            {
                if (cantidad > Saldo)
                {
                    Console.WriteLine("Saldo insuficiente para realizar el retiro.");
                }
                else
                {
                    Saldo -= cantidad;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Se produjo un error: " + e.Message);
            }
            return Saldo;
        }

        public bool IngresarPin(int numero)
        {
            if (numero == Pin)
            {
                Console.WriteLine("PIN correcto. Acceso concedido.");
                return true;
            }
            else
            {
                Console.WriteLine("PIN incorrecto. Acceso denegado.");
                return false;
            }
        }

        public bool CambiarPin(int nuevoPin)
        {
            if (nuevoPin != Pin)
            {
                Pin = nuevoPin;
                Console.WriteLine("PIN cambiado exitosamente.");
                return true;
            }
            else
            {
                Console.WriteLine("El pin actual debe ser distinto al anterior.");
                return false;
            }
        }
    }


}
