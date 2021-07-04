using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Sistemas
{
    public class ParceiroAutenticavel : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new();
        private string _codigoSecreto = "jjj";
        public bool Autenticar(string senha)
        {
            Console.WriteLine("Autenticando parceiro...");

            if (_autenticacaoHelper.CompararSenhas(_codigoSecreto, senha))
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
