using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Contas
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank.
    /// </summary>
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

        /// <summary>
        /// Cria uma instância de Conta Corrente com os argumentos recebidos.
        /// </summary>
        /// <param name="titular"> Representa a referência da propriedade <see cref="Titular"/>. </param>
        /// <param name="agencia"> Representa o valor da propriedade <see cref="Agencia"/>. </param>
        /// <param name="numero"> Representa o valor da propriedade <see cref="Numero"/>. </param>
        public ContaCorrente(Cliente titular, string agencia, string numero)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

            Console.WriteLine("Parabéns pela nova conta " + Titular.Nome + "! O saldo é de " + Saldo + ".");
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>.
        /// </summary>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é atribuido ao <paramref name="valor"/>. </exception>
        /// <exception cref="SaldoInsuficienteException"> Exceção lançada quando o valor de <paramref name="valor"/> é maior que o <see cref="Saldo"/>. </exception>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor ou igual ao <see cref="Saldo"/>. </param>
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
