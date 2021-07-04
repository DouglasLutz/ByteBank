using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf, string nome, string senha) : 
            base(4000, cpf, nome, senha)
        {
            Console.WriteLine("Novo diretor, seja bem vindo " + Nome + "!");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
            Console.WriteLine("O salario do diretor " + Nome + " aumentou para " + Salario + ", parabéns!");
        }

        public override double GetBonificacao()
        {
            double bonificacao = Salario * 0.5;

            Console.WriteLine("A bonificação do diretor " + Nome + " é " + bonificacao);

            return bonificacao;
        }
    }
}
