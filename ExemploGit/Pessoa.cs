using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploGit
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
    }
}
