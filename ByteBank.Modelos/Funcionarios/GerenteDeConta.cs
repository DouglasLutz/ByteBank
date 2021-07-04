using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf, string nome, string senha) : 
            base(4000, cpf, nome, senha)
        {
            Console.WriteLine("Novo gerente de conta, seja bem vindo " + Nome + "!");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
            Console.WriteLine("O salario do gerente de conta " + Nome + " aumentou para " + Salario + ", parabéns!");
        }

        public override double GetBonificacao()
        {
            double bonificacao = Salario * 0.25;

            Console.WriteLine("A bonificação do gerente de conta " + Nome + " é " + bonificacao);

            return bonificacao;
        }
    }
}
