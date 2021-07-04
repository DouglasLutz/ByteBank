using ByteBank.Modelos.Contas;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistemas;
using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            CodigoDeContas();
            // CodigoDeBonificacoes();
            // CodigoDeSistemaInterno();
        }

        static void CodigoDeContas()
        {
            Cliente douglas = new Cliente("Douglas", "039.735.890.09");
            ContaCorrente cc = new ContaCorrente(douglas, "50", "867432");

            try
            {
                cc.Depositar(1000);
                cc.Sacar(500);
                cc.Sacar(500);
                cc.Sacar(-500);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void CodigoDeBonificacoes()
        {
            GerenciadorDeBonificacoes gb = new GerenciadorDeBonificacoes();

            Funcionario joao = new Auxiliar("039.735.890-38", "Joao");
            joao.AumentarSalario();
            joao.AumentarSalario();
            joao.GetBonificacao();

            Funcionario paula = new Diretor("039.735.890-00", "Paula", "123");
            paula.AumentarSalario();


            gb.RegistrarFuncionario(joao);
            gb.RegistrarFuncionario(paula);
            Console.WriteLine("TOTAL DE BONIFICACOES: " + gb.Bonificacoes);
        }

        static void CodigoDeSistemaInterno()
        {
            SistemaInterno sistema = new();

            Diretor paula = new Diretor("039.735.890-00", "Paula", "123");

            sistema.Logar(paula, "123");
            sistema.Logar(paula, "456");

            ParceiroAutenticavel pa = new ParceiroAutenticavel();
            sistema.Logar(pa, "jjj");
        }
    }
}
