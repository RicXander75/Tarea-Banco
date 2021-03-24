using System;
// Crear un programa que simule un banco que tiene 3 clientes que pueden hacer depositos y retiros, tambien el banco requiere que al final del dia calcule la cantidad de dinero que hay depositado
namespace Banco
{
    public class Cliente
    {
        private string nombre;
        private float saldo;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return this.nombre; 
        }
        public void SetSaldo(float saldo)
        {
            this.saldo = saldo;  
        }
        public float GetSaldo()
        {
            return this.saldo;
        }
        public void Deposito(float dinero)
        {
            this.saldo += dinero;
        }
        public void Retiro(float dinero)
        {
            this.saldo -= dinero;
        }
    }
    public class Banco
    {
        private float dinero;
        public void DepositoCliente(float dinero, Cliente cliente)
        {
            cliente.Deposito(dinero);
            this.dinero += dinero;
        }
        public void RetiroCliente(float dinero, Cliente cliente)
        {
            cliente.Retiro(dinero);
            this.dinero -= dinero;
        }
        public float ObtenerDinero()
        {
            return this.dinero;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Cliente Cliente1 = new Cliente();
            Cliente Cliente2 = new Cliente();
            Cliente Cliente3 = new Cliente();
            Banco banco = new Banco();


            Cliente1.SetNombre("Juan");
            Cliente2.SetNombre("Maria");
            Cliente3.SetNombre("Jose");

            Cliente1.SetSaldo(0);
            Cliente2.SetSaldo(0);
            Cliente3.SetSaldo(0);

            banco.DepositoCliente(100, Cliente1);
            banco.DepositoCliente(500, Cliente2);
            banco.DepositoCliente(3000, Cliente3);

            banco.RetiroCliente(300, Cliente3);

            Console.WriteLine(Cliente1.GetNombre() + " tiene: " + Cliente1.GetSaldo());
            Console.WriteLine(Cliente2.GetNombre() + " tiene: " + Cliente2.GetSaldo());
            Console.WriteLine(Cliente3.GetNombre() + " tiene: " + Cliente3.GetSaldo());
            Console.WriteLine("El banco tiene: " + banco.ObtenerDinero());
        }
    }
}
