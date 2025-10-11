using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        // 'override' sobrescreve o método Apresentar() da classe pai
        public override void Apresentar()
        {
            Console.WriteLine(
                $"Olá, sou o professor {Nome}, tenho {Idade} anos e recebo {Salario:C}"
            );
        }
    }
}
