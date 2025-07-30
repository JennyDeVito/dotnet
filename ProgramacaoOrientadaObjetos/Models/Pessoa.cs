using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaObjetos.Models
{
    public class Pessoa
    {
        // um construtor, por padrão é o primeiro item de sua classe todo construtor
        // tem o mesmo nome de sua classe e não tem nenhum tipo de retorno
        // pode receber ou não parâmetros 
        // e uma classe pode ter vários construtores - não há limite 
        public Pessoa() // construtor padrão
        {

        }

        // toda vez que a classe tiver somente um construtor com parâmetros atribuídos, os 
        // parâmetros PRECISAM ser passados ou o compilador apontará um erro (CS7036)
        public Pessoa(string nome, string sobrenome) // construtor
        {
            // ligando os parâmetros às propriedades
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // estas propriedades possuem duas ações possíveis: get e set
        // get é para obter um valor {Nome} 
        // set é para atribuir um valor (Nome = "Jenny")
        // se deixar o padrão da prop { get; set; } o c# aceita quaisquer valores

        // a diferença entre propriedades e campos é que campos têm o { get; set; } 
        // (podendo ter somente get ou somente set) e os campos não tem get e set

        // Usamos a técnica de encapsulamento que é proteger seus atributos de 
        // modificações externas cujos valores não tenham passado por validações 
        // através de propriedades ou de métodos
        // Na técnica de encapsulanento cria-se uma variável auxiliar (que só é 
        // manipulável pela própria classe [private]) e essa variável auxiliar é  
        // quem passará a armazenar o atributo

        // iniciar _nome e _sobrenome com "" para garantir que a string nunca sejam 
        // nulas e não ativem os protocolos de nulabilidade do compilador

        // utilizamos [public] para dizer que qualquer um pode acessar, ou instanciar, 
        // a classe ou propriedade
        // já quando utilizamos [private] a propriedade ou classe só é acessível de dentro 
        // da classe à qual está declarada, ou seja, ela é restrita à sua propria classe
        // e não pode ser manipulada ou instanciada (e modificar ou fazer atribuição de  
        // valores) a partir do Program.cs, ou de outra classe, por exemplo

        // Desconstrutor
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome = "";
        private string _sobrenome = "";
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();
            // pode ser substiuído pela linha acima ↑
            // {
            //     return _nome.ToUpper();
            // }

            set
            {
                if (value == "")
                {
                    // exibe a mensagem e para a execução do programa 
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
            }
        }
        
        //validando o sobrenome do mesmo jeito que validamos o nome
        public string Sobrenome
        {
            get => _sobrenome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio!");
                }
                _sobrenome = value;
            }
        }

        // propriedade que serve apenas para juntar duas propriedades então, não 
        // faz sentido ter um set pois as duas propriedade que serão juntadas 
        // dentro dela já possuem seus respectivos set, deste modo será uma 
        // propriedade somente leitura não sendo possível fazer a atribuição de 
        // valores a ela pelo Program.cs - é apenas get
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero!");
                }
                _idade = value;
            }
        }

        // o método Apresentar() é uma ação que a classe Pessoa pode fazer
        public void Apresentar()
        {
            // alteramos a linha da aula que tinha .ToUpper() no final pois o sobrenome foi 
            // validado e alterado igual ao nome - já deixamos em maiúsculas lá na classe 
            // Sobrenome, não precisava fazer novamente na classe NomeCompleto
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}.");
        }
       
    }
}