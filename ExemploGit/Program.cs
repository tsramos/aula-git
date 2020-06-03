using System;

namespace ExemploGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Pessoa", new DateTime(2000,08,01));
            Console.WriteLine("Terminei essa merda com sucesso acho que eles entenderam ,...");

            Console.WriteLine("Mensagem qualquer ai pra nois");

            Console.WriteLine("Aluno Thiago > Alunos IFPR");
            Pessoa fagner = new Pessoa("Fagner", DateTime.Now);
            Console.WriteLine("Salvando alteracao antes do pull");

        }
    }
}
