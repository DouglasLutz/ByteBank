using ByteBank.Modelos.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private string _senha;

        public FuncionarioAutenticavel(double salario, string cpf, string nome, string senha) :
            base(salario, cpf, nome)
        {
            _senha = senha;
        }

        public bool Autenticar(string senha)
        {
            Console.WriteLine("Autenticando usuário " + Nome + "...");

            if (senha == _senha)
            {
                Console.WriteLine("Senha correta!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
