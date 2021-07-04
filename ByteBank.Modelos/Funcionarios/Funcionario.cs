using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, string nome)
        {
            CPF = cpf;
            Salario = 2000;
            Nome = nome;

            TotalFuncionarios++;
        }

        protected Funcionario(double salario, string cpf, string nome)
        {
            CPF = cpf;
            Salario = salario;
            Nome = nome;

            TotalFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
