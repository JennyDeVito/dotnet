// deve ser o mesmo namespace da classe
// using ExemploFundamentos.Common.Models;

// PRIMEIRO PROGRAMA: ATRIBUIÇÃO DE CLASSE
// FIRST PROGRAM: CLASS ATRIBUTION
// // "pessoa1" eh o nome da variavel que sera utilizada na classe pessoa :)
// Pessoa pessoa1 = new Pessoa();
// // atribuicao dos dados para a classe
// // passando os dados
// pessoa1.Nome = "Jenny";
// pessoa1.Idade = 36;
// // chamada do metodo
// pessoa1.Apresentar();
// --------FIM DO PROGRAMA 1--------


// SEGUNDO PROGRAMA: ATRIBUIÇÃO DE VARIÁVEIS
// SECOND PROGRAM: VARIABLE ATRIBUTION
// string apresentacao = "Olá, seja bem-vindo!";
// int quantidade = 1;
// Console.WriteLine("Valor inicial da variável quantidade: " + quantidade);
// // reatribuicao da varavel - nao pode declarar novamente o tipo 
// quantidade = 10; 
// double altura = 1.80d;
// decimal preco = 1.80m;
// bool condicao = true;
// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Novo valor da variável quantidade: " + quantidade);
// Console.WriteLine("Teste variável altura: " + altura);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);
// Console.WriteLine("Data atual: " + dataAtual); 
// Console.WriteLine("Data atual formatada: " + dataAtual.ToString("dd/MM/yyyy HH:mm:ss"));
// --------FIM DO PROGRAMA 2--------


// TERCEIRO PROGRAMA: OPERADOR DE ATRIBUIÇÃO (=)
// THIRD PROGRAM: OPERATOR OF ATTRIBUTION (=)
// Operador de atribuição é utilizado para atribuir valores a variáveis
// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5; // Mesma coisa que c = c + 5;
// c -= 3; // Mesma coisa que c = c - 3;
// c *= 2; // Mesma coisa que c = c * 2;
// c /= 5; // Mesma coisa que c = c / 5;

// Console.WriteLine("Valor de c: " + c);
// --------FIM DO PROGRAMA 3--------


// QUARTO PROGRAMA: CONVERTENDO TIPOS DE DADOS
// FOURTH PROGRAM: CONVERTING DATA TYPES
// // cast ou casting é a conversão de um tipo de dado para outro - usando
// // a classe Convert e o metodo .ToInt32() com a string "5" como argumento
// int a = Convert.ToInt32("5");
// // a variavel a agora é do tipo inteiro e recebe o valor 5

// // outra forma de conversão é usando o método Parse
// int b = int.Parse("10");
// // Parse já converte a string "10" para o tipo inteiro de 32-bit 
// // e atribui o valor 10 à variável b

// int c;
// bool parseResult = int.TryParse("2d", out c);

// // a diferença entre o uso do Parse e o Convert está na forma como lidam com
// // valores nulos 
// int d = Convert.ToInt32(null);

// // Parse lançará uma exceção se o valor for nulo e encerrará o programa
// // int e = int.Parse(null);

// // É recomendado usar o método Convert para evitar que o programa dê erro
// // caso o valor seja nulo, pois ele retornará 0 e, nesse caso, podemos
// // programá-lo para lidar com isso

// Console.WriteLine("Valor de a: " + a);
// Console.WriteLine("Valor de b: " + b);
// Console.WriteLine(parseResult); // Mostra se a conversão foi bem-sucedida
// Console.WriteLine("Valor de c: " + c); // Se a conversão falhar, c será 0
// Console.WriteLine("Valor de d: " + d); // Convert retorna 0 se o valor for nulo
// // Console.WriteLine("Valor de e: " + e); 
// -------- FIM DO PROGRAMA 4 --------


// QUINTO PROGRAMA: CONVERSÃO PARA STRING
// FIFTH PROGRAM: CONVERSION TO STRING
// int inteiro = 5;
// // string a = inteiro; // nao podemos converter diretamente
// // precisamos usar o método ToString() para converter o inteiro em string
// string a = inteiro.ToString();
// // não precisa utilizar o Parse (pq não tem) nem o Convert pq todo tipo de dado
// // pode ser convertido para string usando o método ToString()

// Console.WriteLine("Valor de a: " + a); // Mostra o valor de a como string
// -------- FIM DO PROGRAMA 5 --------


// SEXTO PROGRAMA: CASTING IMPLICITO
// SIXTH PROGRAM: IMPLICIT CASTING
// // é a conversão automática de um tipo de dado para outro
// int a = 10;
// double b = a;

// double c = 5.5;
// // int d = Convert.ToInt32(c); // d = 6, pois arredonda
// int d = (int)c; // ou podemos usar o cast explícito - d = 5, pois não arredonda

// Console.WriteLine(b);
// Console.WriteLine(d); // d = 6 pois arredonda

// // converte a de int para b que é double sem erros e sem métodos
// // mas só funciona se o tipo de dado para converter for menor que o tipo de
// // para o qual será convertido - o inverso não funciona
// -------- FIM DO PROGRAMA 6 --------


// SÉTIMO PROGRAMA: ORDEM DE PRECEDÊNCIA
// SEVENTH PROGRAM: ORDER OF PRECEDENCE
// // P E D/M A/S 

// // double a = 4 / 2 + 2; // 4 dividido por 2 é 2, depois soma 2, resultado é 4

// double a = 4 / (2 + 2); // 2 + 2 é 4, depois 4 dividido por 4, resultado é 1

// Console.WriteLine(a);
// -------- FIM DO PROGRAMA 7 --------


// OITAVO PROGRAMA: CONVERTENDO DE MANEIRA SEGURA - USANDO TRY PARSE
// EIGHTH PROGRAM: SAFE CONVERSION - USING TRY PARSE
// string a = "15";
// int b = Convert.ToInt32(a);

// Console.WriteLine(b); // Mostra o valor convertido de string para int
// Console.WriteLine("Conversão realizada com sucesso!");

// // string c = "2c"; // Exemplo de string que não pode ser convertida diretamente
// string c = "45"; // Exemplo de string que pode ser convertida

// // int d = 0; // essa variavel pode ser inicializada dentro do TryParse

// int.TryParse(c, out int d); // Tenta converter a string c para int

// Console.WriteLine(d); // Mostra o valor convertido ou 0 se falhar
// Console.WriteLine("Tentativa de conversão realizada com TryParse.");
// ------- FIM DO PROGRAMA 8 --------

// NONO PROGRAMA: OPERADOR CONDICIONAL
// NINTH PROGRAM: CONDITIONAL OPERATOR
// int quantidadeEmEstoque = 15;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade solicitada: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda efetuada.");
//     quantidadeEmEstoque -= quantidadeCompra;
//     Console.WriteLine($"Estoque atualizado: {quantidadeEmEstoque}");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos estoque suficiente.");
// }
// ------- FIM DO PROGRAMA 9 --------


// DÉCIMO PROGRAMA: OPERADOR CONDICIONAL ANINHADO
// TENTH PROGRAM: NESTED CONDITIONAL OPERATOR
// int quantidadeEmEstoque = 15;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade solicitada: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Quantidade inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda efetuada.");
//     quantidadeEmEstoque -= quantidadeCompra;
//     Console.WriteLine($"Estoque atualizado: {quantidadeEmEstoque}");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos estoque suficiente.");
// }
// ------- FIM DO PROGRAMA 10 --------


// DÉCIMO PRIMEIRO PROGRAMA: SWITCH CASE
// ELEVENTH PROGRAM: SWITCH CASE
// Console.WriteLine("Digite uma letra: ");

// string? letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }

// Usando switch case
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }
// ------- FIM DO PROGRAMA 11 --------


// DÉCIMO SEGUNDO PROGRAMA: TESTE DE IDADE COM IF ANINHADO
// TWELFTH PROGRAM: AGE TEST WITH NESTED IF
// Console.WriteLine("Digite sua idade: ");
// string? idade = Console.ReadLine();

// int.TryParse(idade, out int idadeConvertida);

// if (idadeConvertida == 0)
// {
//     Console.WriteLine("Idade inválida.");
// }
// else if (idadeConvertida < 0)
// {
//     Console.WriteLine("Idade não pode ser negativa.");
// }
// else if (idadeConvertida < 18)
// {
//     Console.WriteLine("Possui autorização do responsável? (s/n)");
//     string? autorizacao = Console.ReadLine();
//     if (autorizacao?.ToLower() == "s")
//     {
//         Console.WriteLine("Entrada permitida.");
//     }
//     else
//     {
//         Console.WriteLine("Entrada não permitida. Você é menor de idade e não possui autorização.");
//     }
// }
// else if (idadeConvertida >= 18)
// {
//     Console.WriteLine("Entrada permitida.");
// }
// ------- FIM DO PROGRAMA 12 --------


// DÉCIMO TERCEIRO PROGRAMA: OR (||)
// THIRTEENTH PROGRAM: OR (||)
// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada proibida!");
// }
// ------- FIM DO PROGRAMA 13 --------


// DÉCIMO QUARTO PROGRAMA: AND (&&)
// FOURTEENTH PROGRAM: AND (&&)
// bool possuiPresencaMinima = true;
// double media = 8.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }
// ------- FIM DO PROGRAMA 14 --------


// DÉCIMO QUINTO PROGRAMA: NOT (!)
// FIFTEENTH PROGRAM: NOT (!)
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }
// ------- FIM DO PROGRAMA 15 --------


// DÉCIMO SEXTO PROGRAMA: INSTANCIANDO A CALCULADORA
// SIXTEENTH PROGRAM: INSTANTIATING THE CALCULATOR
// Calculadora calc = new Calculadora();

// calc.Somar(15, 8);
// calc.Subtrair(8, 40);
// calc.Multiplicar(6, 7);
// calc.Dividir(60, 15);
// calc.Potencia(2, 13);
// calc.Cosseno(30);
// calc.Seno(45);
// calc.Tangente(60);
// calc.RaizQuadrada(144);
// ------- FIM DO PROGRAMA 16 --------


// DÉCIMO SÉTIMO PROGRAMA: INCREMENTO E DECREMENTO
// SEVENTEENTH PROGRAM: INCREMENT AND DECREMENT
// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine($"Incrementando {numero}");
// numero++;

// Console.WriteLine(numero);

// int outroNumero = 20;

// Console.WriteLine(outroNumero);

// Console.WriteLine($"Decrementando {outroNumero}");
// outroNumero--;

// Console.WriteLine(outroNumero);
// ------- FIM DO PROGRAMA 17 --------

// DÉCIMO OITAVO PROGRAMA: FOR
// EIGHTEENTH PROGRAM: FOR
// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }
// ------- FIM DO PROGRAMA 18 --------

// DÉCIMO NONO PROGRAMA: WHILE
// NINETEENTH PROGRAM: WHILE
// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 5)
//     {
//         break;
//     }
// }
// ------- FIM DO PROGRAMA 19 --------


// VIGÉSIMO PROGRAMA: DO-WHILE
// TWENTIETH PROGRAM: DO-WHILE
// int soma = 0, numero;
// string? entrada;

// do
// {
//     Console.WriteLine("Digite um número para somar ou 0 para parar: ");
//     entrada = Console.ReadLine();
//     bool resultadoParse = int.TryParse(entrada, out numero);
//     if (!resultadoParse)
//     {
//         Console.WriteLine("Digite um número válido!");
//     }
//     soma += numero;

// } while (entrada != "0");

// Console.WriteLine($"A soma dos números digitados é {soma}.");
// ------- FIM DO PROGRAMA 20 --------


// VIGÉSIMO PRIMEIRO PROGRAMA: MENU INTERATIVO
// TWENTY-FIRST PROGRAM: INTERACTIVE MENU
// string? opcao;

// while (true)
// {
//     Console.WriteLine("Digite sua opção: ");
//     Console.WriteLine("1) Cadastrar cliente");
//     Console.WriteLine("2) Buscar cliente");
//     Console.WriteLine("3) Apagar cliente");
//     Console.WriteLine("4) Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente: ");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente: ");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente: ");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção inválida!");
//             break;
//     }
// }
// ------- FIM DO PROGRAMA 21 --------


// VIGÉSIMO SEGUNDO PROGRAMA: MENU INTERATIVO REFATORADO
// TWENTY-SECOND PROGRAM: REFACTORED INTERACTIVE MENU
// string? opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     //Console.Clear();
//     Console.WriteLine("Digite sua opção: ");
//     Console.WriteLine("1) Cadastrar cliente");
//     Console.WriteLine("2) Buscar cliente");
//     Console.WriteLine("3) Apagar cliente");
//     Console.WriteLine("4) Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente: ");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente: ");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente: ");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção inválida!");
//             break;
//     }
// }

// Console.WriteLine("O programa será encerrado!");
// ------- FIM DO PROGRAMA 22 --------


// VIGÉSIMO TERCEIRO PROGRAMA: NOVA INSTÂNCIA DE PESSOA
// TWENTY-THIRD PROGRAM: NEW INSTANCE OF PERSON
// using ExemploFundamentos.Common.Models;

// Pessoa pessoa2 = new Pessoa();
// pessoa2.Nome = "Daniel";
// pessoa2.Idade = 37;
// pessoa2.Apresentar();
// ------- FIM DO PROGRAMA 23 --------


// VIGŚIMO QUARTO PROGRAMA: ARRAY
// TWENTY-FOURTH PROGRAM: ARRAY
// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 27;
// arrayInteiros[1] = 35;
// arrayInteiros[2] = 84;
// // arrayInteiros[3] = 12; // System.IndexOutOfRangeException

// Console.WriteLine($"Tamanho da array: {arrayInteiros.Length}");

// // usando for para percorrer a array
// Console.WriteLine("\nPercorrendo a array com o for:");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição: {contador} | Valor: {arrayInteiros[contador]}");
// }


// // usando foreach para percorrer a array
// Console.WriteLine("\nPercorrendo a array com o foreach:");
// int contador2 = 0; // serve só para imprimir a posição
// foreach (int valor in arrayInteiros)
// {
//     // precisa fazer o gerenciamento de contador à parte
//     Console.WriteLine($"Posição: {contador2} | Valor: {valor}");
//     contador2++;
// }

// // um array nasce e morre do mesmo tamanho 
// // uma alternativa é usar o Array.Resize para alterar o tamanho de uma array

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// Console.WriteLine($"\nTamanho da array: {arrayInteiros.Length}");
// Console.WriteLine("\nPercorrendo a array com o for:");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição: {contador} | Valor: {arrayInteiros[contador]}");
// }

// // mas no segundo argumento dá para passar um int como o valor do novo
// // tamanho da array, por exemplo "10"

// Array.Resize(ref arrayInteiros, 10);
// Console.WriteLine($"\nTamanho da array: {arrayInteiros.Length}");
// Console.WriteLine("\nPercorrendo a array com o for:");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição: {contador} | Valor: {arrayInteiros[contador]}");
// }

// // as novas posições são inicializadas com 0

// ------- FIM DO PROGRAMA 24 --------


// VIGÉSIMO QUINTO PROGRAMA: COPIANDO UM ARRAY
// TWENTY-FIFTH PROGRAM: COPYING ARRAYS
// simulando o comando Array.Resize()
// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 27;
// arrayInteiros[1] = 35;
// arrayInteiros[2] = 84;
// arrayInteiros[3] = 12;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Console.WriteLine($"\nTamanho da array: {arrayInteirosDobrado.Length}");
// Console.WriteLine("\nPercorrendo a array com o for:");
// for (int contador = 0; contador < arrayInteirosDobrado.Length; contador++)
// {
//     Console.WriteLine($"Posição: {contador} | Valor: {arrayInteirosDobrado[contador]}");
// }
// ------- FIM DO PROGRAMA 25 --------


// VIGÉSIMO SEXTO PROGRAMA: LISTAS
// TWENTY-SIXTH PROGRAM: LISTS
// List<string> listaString = new List<string>();

// // adicionando elementos um a um
// listaString.Add("RJ");
// listaString.Add("CE");
// listaString.Add("AC");

// // percorrendo a lista com for
// Console.WriteLine("Percorrendo a lista com for:");
// for (int contador3 = 0; contador3 < listaString.Count; contador3++)
// {
//     Console.WriteLine($"Posição: {contador3} | Valor: {listaString[contador3]}");
// }

// // adicionando vários elementos
// listaString.AddRange("PE", "MA", "MG", "ES");

// // percorrendo a lista com foreach
// Console.WriteLine("\nPercorrendo a lista com for:");
// int contador4 = 0;
// foreach (string estado in listaString)
// {
//     Console.WriteLine($"Posição: {contador4} | Valor: {estado}");
//     contador4++;
// }

// Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("AM");

// Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MA");

// Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// // inserindo dados na lista com entrada do usuário e validação de valores nulos
// Console.WriteLine("\nInsira a sigla de um estado: ");
// string? entrada = Console.ReadLine();
// if (!string.IsNullOrEmpty(entrada))
//     listaString.Add(entrada);

// // percorrendo a lista com for
// Console.WriteLine("Percorrendo a lista com for:");
// for (int contador5 = 0; contador5 < listaString.Count; contador5++)
// {
//     Console.WriteLine($"Posição: {contador5} | Valor: {listaString[contador5]}");
// }

// ------- FIM DO PROGRAMA 26 --------


// VIGÉSIMO SÉTIMO PROGRAMA: DESAFIO DE CÓDIGO
// TWENTY-SEVENTH PROGRAM: CODE CHALLENGE

// // Lê o valor original do produto
// double valorOriginal = Convert.ToDouble(Console.ReadLine());

// // Lê a porcentagem de desconto
// double porcentagemDesconto = Convert.ToDouble(Console.ReadLine());

// if (porcentagemDesconto < 0 || porcentagemDesconto > 100)
// {
//     Console.WriteLine("Desconto invalido");
// }
// else
// {
//     double valorFinal = valorOriginal - (valorOriginal * (porcentagemDesconto / 100));
//     // Exibe o valor com duas casas decimais
//     Console.WriteLine($"{valorFinal:F2}");
// }
// ------- FIM DO PROGRAMA 27 --------

