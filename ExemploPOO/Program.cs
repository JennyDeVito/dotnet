using System.Globalization;
using ExemploPOO.Models;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// 50º PROGRAMA: CRIANDO O OBJETO PESSOA
// 50TH PROGRAM: CREATING A PERSON OBJECT
// // instanciar uma nova classe é concretizar um novo objeto daquela classe
// // é criar um objeto (pessoa1) daquele tipo de classe
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Jenny";
// pessoa1.Idade = 36;

// pessoa1.Apresentar();

// //Console.WriteLine(pessoa1.ToString());
// ----------END 50TH PROGRAM----------

// 51º PROGRAMA: CRIANDO O OBJETO CONTA CORRENTE
// 51ST PROGRAM: CREATING A CHECKING ACCOUNT OBJECT
// ContaCorrente conta1 = new ContaCorrente(1234, 5000.65m);

// conta1.ExibirSaldo();

// Console.WriteLine();

// conta1.Sacar(2000.65m);
// conta1.ExibirSaldo();

// Console.WriteLine();

// conta1.Sacar(3050.00m);
// conta1.ExibirSaldo();

// Console.WriteLine();

// conta1.Deposito(1000m);
// conta1.ExibirSaldo();
// ----------END 51ST PROGRAM----------

// 52º PROGRAMA: EXPERIMENTANDO HERANÇA E POLIMORFISMO
// 52ND PROGRAM: EXPERIMENTIG HERITAGE AND POLIMORFISM
Pessoa pessoa2 = new Pessoa();

pessoa2.Nome = "Jenny";
pessoa2.Idade = 45;
Console.WriteLine($"\nApresentando a classe pai {pessoa2}:");
pessoa2.Apresentar();

Aluno aluno1 = new Aluno();

aluno1.Nome = "Bruno";
aluno1.Idade = 30;
aluno1.Nota = 8;
Console.WriteLine($"\nApresentando a classe filha {aluno1}:");
aluno1.Apresentar();

Professor professor1 = new Professor();

professor1.Nome = "Daniel";
professor1.Idade = 37;
professor1.Salario = 5000m;
Console.WriteLine($"\nApresentando a classe filha {professor1}:");
professor1.Apresentar();
// ----------END 52ND PROGRAM----------
