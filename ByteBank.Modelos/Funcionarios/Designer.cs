using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf, string nome) : base(3000, cpf, nome)
        {
            Console.WriteLine("Novo designer, seja bem vindo " + Nome + "!");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
            Console.WriteLine("O salario do designer " + Nome + " aumentou para " + Salario + ", parabéns!");
        }

        public override double GetBonificacao()
        {
            double bonificacao = Salario * 0.17;

            Console.WriteLine("A bonificação do designer " + Nome + " é " + bonificacao);
            
            return bonificacao;
        }
    }
}
