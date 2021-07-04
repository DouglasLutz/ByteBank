using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Contas
{
    public class ContaCorrente
    {
        private double _saldo;
        public Cliente Titular { get; }
        public string Agencia { get; }
        public string Numero { get; }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
        }

        public static int TotalDeContasCriadas { get; private set; }


        public ContaCorrente(Cliente titular, string agencia, string numero)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

            Console.WriteLine("Parabéns pela nova conta " + Titular.Nome + "! O saldo é de " + Saldo + ".");
        }


        public void Sacar(double valor)
        {
            Console.WriteLine(Titular.Nome + " está sacando R$" + valor + " de sua conta.");

            if (valor < 0)
                throw new ArgumentException("Não pode ser menor do que 0.", nameof(valor));
            if (Saldo < valor)
                throw new SaldoInsuficienteException(Saldo, valor);

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Console.WriteLine(Titular.Nome + " está depositando R$" + valor + " em sua conta.");

            if (valor < 0)
                throw new ArgumentException("Não pode ser menor do que 0.", nameof(valor));

            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente conta)
        {
            Console.WriteLine(Titular.Nome + "está transferindo R$" + valor + " para a conta de " + conta.Titular.Nome + ".");

            this.Sacar(valor);
            conta.Depositar(valor);
        }

        public override string ToString()
        {
            return "%ContaCorrente{\nTitular: " + Titular + 
                "\nAgencia: " + Agencia +
                "\nNumero: " + Numero +
                "\nSaldo: " + Saldo + "}";
        }
    }
}
