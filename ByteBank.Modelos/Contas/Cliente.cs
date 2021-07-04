using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Contas
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; }
        public string Email { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;

            Console.WriteLine("Novo cliente, seja bem-vindo " + Nome + "!");
        }


        public override string ToString()
        {
            return "%Cliente{\nNome: " + Nome +
                "\nCpf: " + CPF +
                "\nEmail: " + Email + "}";
        }
    }
}
