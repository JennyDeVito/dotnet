using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaObjetos.Models
{
    public class Curso
    {
        // como nullable está enabled Nome e Lista devem ser iniciadas 
        // vazias para que o compilador não dê warning de nulabilidade (CS8618) 
        // elas são declaradas como não anuláveis mas foram inicializadas
        // nulas, aí o compilador dá o warning

        // Nome aqui é o nome do curso
        public string Nome { get; set; } = "";
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        // criação do método que recebe os alunos na lista Alunos 
        // a lista Alunos recebe itens da classe Pessoa armazenados
        // na variável aluno
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        // metodo para contar os alunos matriculados
        public int QuantidadeAlunosMatriculados()
        {
            // usar somente a linha abaixo ↓ resolve o código de maneira simples
            return Alunos.Count;
            // a criação de uma variável auxiliar para retornar os alunos 
            // matriculados só seria útil caso esse valor fosse ser utilizado 
            // novamente dentro do método - o que não é o caso
            // int quantidadeMatriculados = Alunos.Count;
            // return quantidadeMatriculados;
        }

        // método para remover alunos
        public bool RemoverAluno(Pessoa aluno)
        {
            // Remove() é um método que retorna um booleano de true caso consiga 
            // remover o valor da lista e falso caso o valor não esteja na lista
            return Alunos.Remove(aluno);
        }

        // método para listar alunos
        public void ListarAlunos()
        {
            for (int contador = 0; contador < Alunos.Count; contador++)
            {
                // Variável para exemplificar o conceito de concatenação de string
                string textoConcatenado = "Aluno nº " + (contador + 1) + ": " + Alunos[contador].NomeCompleto;

                // Variável para exemplificar o conceito de interpolação de string
                string textoInterpolado = $"Aluno nº {contador + 1}: {Alunos[contador].NomeCompleto}";

                // Console.WriteLine(textoConcatenado);
                Console.WriteLine(textoInterpolado);
                // A concatenação pode ser feita dentro do método WriteLine()
                // o resultado é o mesmo e usa menos código
                // Console.WriteLine($"Aluno nº {contador + 1}: {Alunos[contador].NomeCompleto}");
            }
        }

        // método que diz o nome do curso
        public void InformaCurso()
        {
            // Exemplo de concatenação de texto com propriedade
            Console.WriteLine($"Este é o curso de {Nome}");
        }
    }
}