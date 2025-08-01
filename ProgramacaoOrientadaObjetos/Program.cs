using ProgramacaoOrientadaObjetos.Models;
using System.Data.Common;

// alterando a cultura do sistema
using System.Globalization;

// utilizando o pacote nuget de serialização e deserialização
using Newtonsoft.Json;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// 28º: INSTANCIANDO UMA NOVA PESSOA
// 28TH: INSTANTIANTING A NEW PERSON
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Jenny";
// pessoa1.Sobrenome = "DeVito";
// pessoa1.Idade = 25;
// pessoa1.Apresentar();
// ----------END 28TH PROGRAM----------


// 29º: USANDO A CLASSE CURSO
// 29TH: USING THE CURSO CLASS
// // pelo construtor 2 eu posso instanciar minha classe pessoa assim
// Pessoa pessoa2 = new Pessoa("Olga", "Tinha");

// // pelo construtor padrão é assim que eu instancio a classe pessoa
// Pessoa pessoa3 = new Pessoa();
// pessoa3.Nome = "Frida";
// pessoa3.Sobrenome = "Maria da Silva";

// // notação para deixar mais legíveis quais são os parâmetros
// // não influencia a execução do código
// Pessoa pessoa4 = new Pessoa(nome: "Edith", sobrenome: "Miaph");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.InformaCurso();
// cursoDeIngles.AdicionarAluno(pessoa2);
// cursoDeIngles.AdicionarAluno(pessoa3);
// cursoDeIngles.AdicionarAluno(pessoa4);
// cursoDeIngles.ListarAlunos();
// Console.WriteLine($"O curso tem {cursoDeIngles.QuantidadeAlunosMatriculados()} alunos matriculados");
// cursoDeIngles.RemoverAluno(pessoa4);
// if (!cursoDeIngles.RemoverAluno(pessoa4))
// {
//     Console.WriteLine($"Aluno removido com sucesso!");
// }
// else
// {
//     Console.WriteLine("Aluno não existe!");
// }
// cursoDeIngles.ListarAlunos();
// Console.WriteLine($"Agora, o curso tem {cursoDeIngles.QuantidadeAlunosMatriculados()} alunos matriculados");

// // TODO: fazer menu para manipulação da classe curso
// ----------END 29TH PROGRAM----------


// 30º PROGRAMA: USANDO + EM STRING E INTS
// 30TH PROGRAM: USING + IN STRINGS AND INTS
// string numero1 = "10";
// string numero2 = "20";
// int numero3 = 30;

// string resultado = numero1 + numero2;
// Console.WriteLine($"A tentativa de somar duas strings é uma concatenação: {resultado}");

// int resultadoInteiro = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);
// Console.WriteLine($"Para somar duas strings que contenham números inteiros" +
//     $"é preciso convertê-las antes: {resultadoInteiro}");

// // interessante que uma das variáveis a ser concatenada precisa ser uma string
// string resultadoMisturado = numero1 + numero3;
// Console.WriteLine($"Quando se coloca um inteiro dentro de uma string acontece um cast implicito: {resultadoMisturado}");
// // ----------END 30TH PROGRAM----------


// 31º PROGRAMA: FORMATANDO VALORES MONETÁRIOS
// 31ST PROGRAM: FORMATTING CURRENCY
// decimal valorMonetario = 1245.875m;

// // ':C' para representar a moeda do sistema
// Console.WriteLine($"{valorMonetario:C}");

// // criar uma cultura específica por impressão
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("jp-JP")));
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));

// // o numero após :C indica a quantidade de casas decimais
// Console.WriteLine($"{valorMonetario:C3}");

// // :Cx pode ser substituído por :Nx e o indicador de moeda será omitido
// Console.WriteLine($"{valorMonetario:N3}");
// ----------END 31ST PROGRAM----------


// 32º PROGRAMA: REPRESENTANDO PORCENTAGEM
// 32ND PROGRAM: REPRESENTING PERCENTAGE
// double porcentagem = .3423;

// Console.WriteLine(porcentagem.ToString("P"));
// ----------END 32ND PROGRAM----------


// 32º PROGRAMA: REPRESENTAÇÃO PERSONALIZADA
// 32RD PROGRAM: PERSONALIZED REPRESENTATION
// int numero4 = 234567;

// Console.WriteLine(numero4.ToString("##-##-##"));
// ----------END 33RD PROGRAM----------


// 34º PROGRAMA: FORMATANDO DATA E HORA
// 34TH PROGRAM: FORMATTING DATE AND TIME
// DateTime data = DateTime.Now;

// // imprime o formato padrão da data e da hora
// Console.WriteLine(data);

// // formatado para não imprimir os segundos
// Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));

// // formatação mais extensa
// Console.WriteLine(data.ToString("ddd dd/MMMM/yyyy HH:mm"));

// // somente data
// Console.WriteLine(data.ToShortDateString());

// // somente hora
// Console.WriteLine(data.ToShortTimeString());
// ----------END 34TH PROGRAM----------


// 35º PROGRAMA: CONVERTENDO DATA E HORA
// 35TH PROGRAM: CONVERTING DATE AND TIME
// DateTime dataParaConversao = DateTime.Parse("25/08/2024 19:25");

// Console.WriteLine(dataParaConversao);
// Console.WriteLine();

// // usando TryParseExact para tentar converter a data inválida
// string dataString = "2024-13-17 18:00";

// //DateTime data2 = DateTime.Parse(dataString); // dá exception pois o mês é inválido!

// bool resultadoConversao = DateTime.TryParseExact(dataString,
//                                                 "yyyy-MM-dd HH:mm",
//                                                 CultureInfo.InvariantCulture,
//                                                 DateTimeStyles.None,
//                                                 out DateTime dataSaida);

// if (resultadoConversao)
// {
//     Console.WriteLine($"Data convertida com sucesso: {dataSaida}");
// }
// else
// {
//     // retorna 01/01/0001 00:00:00 porque o mês é inválido
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }  

// Console.WriteLine();
// // usando TryParseExact para tentar converter a data válida
// dataString = "2024-05-17 18:00";

// resultadoConversao = DateTime.TryParseExact(dataString,
//                                             "yyyy-MM-dd HH:mm",
//                                             CultureInfo.InvariantCulture,
//                                             DateTimeStyles.None,
//                                             out dataSaida);

// if (resultadoConversao)
// {
//     Console.WriteLine($"Data convertida com sucesso: {dataSaida}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }
// ----------END 35TH PROGRAM----------


// 36º PROGRAMA: LENDO UM ARQUIVO
// 36TH PROGRAM: READING A FILE
// Lê o conteúdo de um arquivo
// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// // Imprime o conteúdo do arquivo
// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// ----------END 36TH PROGRAM----------


// 37º PROGRAMA: TRATANDO EXCEÇÕES
// 37TH PROGRAMA: HANDLING EXCEPTIONS
// // tenta executar a leitura do documento
// try
// {

//     string[] linhas1 = File.ReadAllLines("Arquivos/pasta/arquivoLeitur.txt");
//     // dispara a FileNotFoundException

//     foreach (string linha in linhas1)
//     {
//         Console.WriteLine(linha);
//     }

// }
// // Exceção específica para arquivo não encontrado
// catch (FileNotFoundException excecao) // captura a exceção em excecao
// {
//     Console.WriteLine($"O arquivo não foi encontrado: {excecao.Message}");
// }
// // ExceçÃo específica para caminho não encontrado
// catch (DirectoryNotFoundException excecao)
// {
//     Console.WriteLine($"O caminho para a pasta não foi encontrado: {excecao.Message}");
// }
// // Exceção genérica: vale para todas as exceções e precisa estar abaixo das exceções específicas
// catch (Exception excecao) // captura a exceção em excecao
// {
//     Console.WriteLine($"Ocorreu uma exceção: {excecao.Message}");
// }
// // pode vir depois do catch (é opcional) e é executado independente de haver exception
// finally
// {
//     Console.WriteLine("\nEssa linha é executada independentemente de haver tratamento de exceções ou não.");
// }

// // continua executando o código
// Console.WriteLine("\nA exceção foi tratada e o programa continuou a ser executado!");
// ----------END 37TH PROGRAM----------


// 38º PROGRAMA: JOGANDO UMA EXCEÇÃO
// 38TH PROGRAM: THROWING AN EXCEPTION
// new ExemploExcecao().Metodo1();

// Console.WriteLine("\nA exceção foi tratada e o programa continuou a ser executado!");
// ----------END 38TH PROGRAM----------


// 39º PROGRAMA: IMPLEMENTANDO UMA FILA
// 39TH PROGRAM: IMPLEMENTING A QUEUE
// // criando uma fila de inteiros
// Console.WriteLine("Filas");
// Queue<int> fila = new Queue<int>();

// // adicionando elementos à fila
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// fila.Enqueue(10);

// foreach (int elemento in fila)
// {
//     Console.WriteLine(elemento);
// }

// // retira e acrescenta um elemento da lista
// Console.WriteLine($"\nRemove o elemento {fila.Dequeue()} da fila\n");
// fila.Enqueue(2);
// Console.WriteLine("Acrescentado o elemento 2 à fila");

// foreach (int elemento in fila)
// {
//     Console.WriteLine(elemento);
// }
// ----------END 39TH PROGRAM----------


// 40º PROGRAMA: PILHAS
// 40TH PROGRAM: STACKS
// Console.WriteLine("Pilhas");
// Stack<int> pilha = new Stack<int>();

// // adicionando elementos à pilha
// pilha.Push(1);
// pilha.Push(3);
// pilha.Push(5);
// pilha.Push(7);
// pilha.Push(9);

// // laço para percorrer a pilha
// foreach (int camada in pilha)
// {
//     Console.WriteLine(camada);
// }

// // retira elemento da pilha
// Console.WriteLine($"\nRetirado elemento {pilha.Pop()} da pilha\n");

// // laço para percorrer a pilha
// foreach (int camada in pilha)
// {
//     Console.WriteLine(camada);
// }
// ----------END 40TH PROGRAM----------


// 41º PROGRAMA: DICIONÁRIO
// 41ST PROGRAM: DICTIONARY
// // implementa um dicionário <tipo-da-chave, tipo-do-valor>
// // o dictionary garante que os elementos sejam únicos com base na key
// // por isso, as keys não podem se repetir, ou o dict lança uma exceção
// Console.WriteLine("Dicionário");
// Dictionary<string, string> estados = new Dictionary<string, string>();

// // adicionando dados ao dictionary
// estados.Add("CE", "Ceará");
// estados.Add("SP", "São Paulo");
// estados.Add("AM", "Amazonas");
// estados.Add("RJ", "Rio de Janeiro");

// // KeyValuePair<string, string> pode ser substituido por 'var'
// // foreach (var unidade in estados)
// foreach (KeyValuePair<string, string> unidade in estados)
// {
//     Console.WriteLine($"Sigla: {unidade.Key}, Nome: {unidade.Value}");
// }

// // para remover um item de um dicionário basta passar sua chave
// estados.Remove("SP");
// Console.WriteLine("\nRemovido estado de SP da coleção:\n");

// foreach (var unidade in estados)
// {
//     Console.WriteLine($"Sigla: {unidade.Key}, Nome: {unidade.Value}");
// }

// // é possível alteral o values, mas não  as keys nos dictionaries 
// // alterando um value
// estados["RJ"] = "Hell de Janeiro";
// Console.WriteLine("\nAlterado value de RJ:\n");

// foreach (var unidade in estados)
// {
//     Console.WriteLine($"Sigla: {unidade.Key}, Nome: {unidade.Value}");
// }

// // É possível verificar se um elemento existe no dictionary antes de tentar
// // adicioná-lo para evitar levantar exceções
// string chave = "ES";
// Console.WriteLine($"\nVerificando o elemento {chave}\n");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"\nO estado já existe na sua coleção! Tente adicionar outro\n");
// }
// else
// {
//     Console.WriteLine($"O estado {chave} será adicionado à sua coleção:");
//     estados.Add(chave, "Espírito Santo");
//     foreach (var unidade in estados)
//     {
//         Console.WriteLine($"Sigla: {unidade.Key}, Nome: {unidade.Value}");
//     }

// }

// // Obtendo um value do dictionary
// Console.WriteLine($"\nNão não, perdão, {estados["AM"]}");
// ----------END 41ST PROGRAM----------


// 42º PROGRAMA: TUPLA
// 42ND PROGRAM: TUPLE
// // entre parênteses declare os tipos dos dados que serão contidos na sua tupla
// // pode ser uma alternativa para quando não se quer criar uma classe
// // essa é a maneira mais recomendada, pela legibilidade do código
// (int, string, string, decimal) tupla = (123, "Jenny", "DeVito", 1.60m);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

// Console.WriteLine();

// // outra maneira de declarar uma tupla
// ValueTuple<int, string, string, decimal> outraTupla = (124, "Frida", "Maria", 1.63m);

// Console.WriteLine($"ID: {outraTupla.Item1}");
// Console.WriteLine($"Nome: {outraTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outraTupla.Item3}");
// Console.WriteLine($"Altura: {outraTupla.Item4}");

// Console.WriteLine();

// // mais uma maneira de criar tupla
// // aqui, o tipo de dado já é identificado e não precisa ser declarado
// var outroExemploTupla = Tuple.Create(125, "Edith", "Miaph", 1.55m);

// Console.WriteLine($"ID: {outroExemploTupla.Item1}");
// Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");
// Console.WriteLine($"Altura: {outroExemploTupla.Item4}");
// ----------END 42ND PROGRAM----------


// 43º PROGRAMA: MÉTODO COM TUPLA
// 43RD PROGRAM: METHOD W/ TUPLE
// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// // se uma tupla retorna 5 informações, mas eu só uso 4, eu posso usar '_' no lugar da informação
// // descartada, melhorando, assim, a legibilidade do meu código 

// if (sucesso)
// {
//     Console.WriteLine($"O arquivo que você passou tem {quantidadeLinhas} linhas");
//     Console.WriteLine("E foi lido com sucesso! A seguir, leia seu conteúdo: \n");
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Ocorreu um erro na tentativa de ler seu arquivo. Tente novamente.");
// }
// ----------END 43RD PROGRAM----------


// 44º PROGRAMA: DESCONSTRUTOR
// 44TH PROGRAM: DECONSTRUCT
// Pessoa pessoa5 = new Pessoa("Maria", "José da Silva");

// // usando o desconstrutor
// (string inicio, string fim) = pessoa5;

// Console.WriteLine($"{inicio}");
// Console.WriteLine($"{fim}");
// ----------END 44TH PROGRAM----------


// 45º PROGRAMA: OPERADOR TERNÁRIO
// 45TH PROGRAM: TERNARY OPERATOR
// int numero5 = 20;

// if (numero5 % 2 == 0)
// {
//     Console.WriteLine("É par!");
// }
// else
// {
//     Console.WriteLine("Não é par!");
// }

// // tenha certeza de fechar todo o operador ternário dentro de parenteses
// Console.WriteLine($"O número {numero5} é " + ((numero5 % 2 == 0) ? "par" : "ímpar"));
// ----------END 45TH PROGRAM----------


// 46º PROGRAMA: SERIALIZAÇÃO POR ITEM
// 46TH PROGRAM: SERIALIZATION BY ITEM
// // estabelecendo a data da venda
// DateTime dataVenda1 = DateTime.Now;

// Venda venda1 = new Venda(456, "Caneta", 5.15m, dataVenda1);
// Venda venda2 = new Venda(975, "Lapiseira", 12.36m, dataVenda1);
// Venda venda3 = new Venda(74, "Borracha", 2.50m, dataVenda1);

// // aplicando o pacote nuget Newtonsoft.Json item por item
// string serializado1 = JsonConvert.SerializeObject(venda1, Formatting.Indented);
// string serializado2 = JsonConvert.SerializeObject(venda2, Formatting.Indented);
// string serializado3 = JsonConvert.SerializeObject(venda3, Formatting.Indented);

// // imprimindo na tela o formato json
// // Console.WriteLine(serializado1);
// // Console.WriteLine(serializado2);
// // Console.WriteLine(serializado3);

// // escrevendo em um arquivo, item por item
// // como o primeiro método é WriteAllText() ele sempre vai criar um arquivo novo
// File.WriteAllText("Arquivos/vendasItem.json", serializado1);
// File.AppendAllText("Arquivos/vendasItem.json", serializado2);
// File.AppendAllText("Arquivos/vendasItem.json", serializado3);

// // fazendo a leitura do arquivo gravado
// string[] confirmaVendas = File.ReadAllLines("Arquivos/vendasItem.json");
// foreach (string venda in confirmaVendas)
// {
//     Console.WriteLine(venda);
// }
// ----------END 46TH PROGRAM----------


// 47º PROGRAMA: SERIALIZAÇÃO DE LISTAS
// 47TH PROGRAM: SERIALIZATION OF LISTS
// // estabelecendo a data da venda
// DateTime dataVenda2 = DateTime.Now;

// Venda venda4 = new Venda(123, "Caneta Tinteiro", 125.59m, dataVenda2);
// Venda venda5 = new Venda(235, "Lapiseira Técnica", 67.98m, dataVenda2);
// Venda venda6 = new Venda(99, "Borracha Macia", 9.45m, dataVenda2);

// // como temos várias vendas é mais fácil serializá-las em uma coleção
// // e, para tal, vamos criar uma lista de objetos
// List<Venda> colecaoVendas = new List<Venda>();

// // adicionando as vendas à lista
// colecaoVendas.Add(venda4);
// colecaoVendas.Add(venda5);
// colecaoVendas.Add(venda6);

// // aplicando o pacote nuget Newtonsoft.Json diretamente à lista de objetos
// string serializado = JsonConvert.SerializeObject(colecaoVendas, Formatting.Indented);

// // escrevendo a lista serializada no arquivo json
// File.WriteAllText("Arquivos/vendasLista.json", serializado);

// // confirmando a gravação das vendas
// string[] confirmaOutrasVendas = File.ReadAllLines("Arquivos/vendasLista.json");
// foreach (string confirmacao in confirmaOutrasVendas)
// {
//     Console.WriteLine(confirmacao);
// }
// ----------END 47TH PROGRAM----------


// 48º PROGRAMA: DESSERIALIZANDO UM OBJETO
// 48TH PROGRAM: DESERIALIZING AN OBJECT
// depois de receber um arquivo .json, você precisa estudá-lo para apreender
// suas propriedades, neste caso, vamos desserializar o arquivo vendasLista.json
// que contém as propriedades Id (inteiro), Produto (string), Preco (decimal) e 
// DataVenda (data no formato ISO 8601, DateTime), daí, eu começo criando uma 
// classe com as propriedades encontradas

// fazendo a leitura do arquivo com as vendas e armazenando na variável
string conteudoVendas = File.ReadAllText("Arquivos/vendasLista.json");

// desserializando o conteúdo do arquivo em uma lista de objetos da classe Venda
// usando o pacote nuget Newtonsoft.Json 
List<VendaNew> listaVenda = JsonConvert.DeserializeObject<List<VendaNew>>(conteudoVendas)!;
// o null forgving ! está aqui para desligar os warnings da nullable reference ↑

// imprimindo o conteúdo desserializado em tela 
foreach (VendaNew transacao in listaVenda)
{
    Console.WriteLine($"Id: {transacao.Id}, \nProduto: {transacao.Produto}, " +
                        $"\nPreço: {transacao.Preco}, \nData: {transacao.DataVenda}\n");
}
// ----------END 48TH PROGRAM----------


// 49º PROGRAMA: DESSERIALIZANDO UM OBJETO SEM PADRAO
// 49TH PROGRAM: DESERIALIZING AN OBJECT WITHOUT STANDARD
// depois de receber um arquivo .json, você precisa estudá-lo para apreender
// suas propriedades, neste caso, vamos desserializar o arquivo vendasLista.json
// que contém as propriedades Id (inteiro), Produto (string), Preco (decimal) e 
// DataVenda (data no formato ISO 8601, DateTime), daí, eu começo criando uma 
// classe com as propriedades encontradas

// fazendo a leitura do arquivo com as vendas e armazenando na variável
string conteudoVendas2 = File.ReadAllText("Arquivos/vendasListaSemPadrao.json");

// desserializando o conteúdo do arquivo em uma lista de objetos da classe Venda
// usando o pacote nuget Newtonsoft.Json 
List<VendaProp> listaVenda2 = JsonConvert.DeserializeObject<List<VendaProp>>(conteudoVendas2)!;
// o null forgving ! está aqui para desligar os warnings da nullable reference ↑

// imprimindo o conteúdo desserializado em tela 
foreach (VendaProp transacao2 in listaVenda2)
{
    Console.WriteLine($"Id: {transacao2.Id}, \nProduto: {transacao2.Produto}, " +
                        $"\nPreço: {transacao2.Preco}, \nData: {transacao2.DataVenda}\n");
}
// ----------END 49TH PROGRAM----------