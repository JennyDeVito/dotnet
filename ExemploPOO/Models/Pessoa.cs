using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = "";
        public int Idade { get; set; }

        // 'virtual' estabelece que o método Apresentar() poderá ser sobrescrito
        //  pela classe filha se essa assim o desejar
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}