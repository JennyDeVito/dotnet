using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// o namespace nao precisa necessariamente ser o caminho real da classe mas
// precisa ser um caminho logico e que faca sentido para o projeto
namespace dotnet.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public void Apresentar()
        {
            // como pular linha sem quebrar a string e "\n" quebra linha
            Console.WriteLine($"Olá, \n meu nome" +
            $" é {Nome}, e tenho {Idade} anos.");
        }
    }
}