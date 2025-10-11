using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // ' : Pessoa' é a herança que a classe Aluno traz da classe Pessoa
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        // 'override' sobrescreve o método Apresentar() da classe pai
        public override void Apresentar()
        {
            Console.WriteLine(
                $"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}!"
            );
        }
    }
}
