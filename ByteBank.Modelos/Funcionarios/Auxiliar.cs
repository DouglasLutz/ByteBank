using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf, string nome) : base(2000, cpf, nome)
        {
            Console.WriteLine("Novo auxiliar, seja bem vindo " + Nome + "!");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
            Console.WriteLine("O salario do auxiliar " + Nome + " aumentou para " + Salario + ", parabéns!");
        }

        public override double GetBonificacao()
        {
            double bonificacao = Salario * 0.20;

            Console.WriteLine("A bonificação do auxiliar " + Nome + " é " + bonificacao);

            return bonificacao;
        }
    }
}
