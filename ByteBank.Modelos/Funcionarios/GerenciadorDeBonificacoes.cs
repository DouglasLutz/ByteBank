using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class GerenciadorDeBonificacoes
    {
        private double _bonificacoes;
        public double Bonificacoes 
        {
            get
            {
                return _bonificacoes;
            }
        }

        public void RegistrarFuncionario(Funcionario funcionario)
        {
            _bonificacoes += funcionario.GetBonificacao();
        }
    }
}
