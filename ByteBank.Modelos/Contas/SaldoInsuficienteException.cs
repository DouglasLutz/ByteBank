using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Contas
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double Valor { get; }

        public SaldoInsuficienteException() 
        {

        }

        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {

        }

        public SaldoInsuficienteException(string mensagem, Exception innerException)
            : base(mensagem, innerException)
        {

        }

        public SaldoInsuficienteException(double saldo, double valor)
            : this("Não é possível sacar R$" + valor + " de uma conta com apenas R$" + saldo + ".")
        {
            Saldo = saldo;
            Valor = valor;
        }
    }
}
