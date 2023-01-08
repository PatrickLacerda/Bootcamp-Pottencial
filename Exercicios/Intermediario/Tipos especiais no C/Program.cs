// See https://aka.ms/new-console-template for more information
using Tipos_especiais_no_C.Models;
using System.Globalization;
using Newtonsoft.Json;


///METODO DE EXTENSÃO 


int numero = 20;
bool par = false;

// IF TEMÁRIO

par = numero.EhPar();

string mensagem = "O numero" + numero + "" + "é" + (par? "par" : "impar");
Console.WriteLine(mensagem);


/// FIM DE METODO DE EXTENSÃO 

//Classe Generica

// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arraystring = new MeuArray<string>();
// arraystring.AdicionarElementoArray("Teste");
// Console.WriteLine(arraystring[0]);

//****Fim Classe Generica ***///

// VARIAVEL DINAMICA - altera tipo de variavel conforme atribui valor para ela

// dynamic variavelDinamica = 4 ; // o valor inteiro ela vai assumir o valor do tipo inteiro

// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica} ");

// variavelDinamica = "texto" ; // o valor inteiro ela vai assumir o valor do tipo inteiro

// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica} ");

// variavelDinamica = true ; // o valor inteiro ela vai assumir o valor do tipo inteiro

// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica} ");

//**** FIM variavel do tipo dinamica ****////

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);


// // é como se fosse um select dos itens apenas que os campos que interessa
// //OBJETO ANONIMO CONSEGUE LIMITAR COM O QUE DESEJA TRAZER.


// var listaAnonimo = listaVenda.Select(x => new{x.Produto, x.Preco});

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }


// // EXEMPLO DA AULA DE STACK, GEAP, GARBAGE COLLECTOR 

// Pessoa p1 = new Pessoa(nome: "Patrick", sobrenome: "Lacerda");
// //Pessoa p2 = new Pessoa (nome: "Leonardo", sobrenome: "Butta");

// Pessoa p2 = p1; // quando coloca p2 = p1 não está fazendo uma copia de P1, mas sim apontando para o mesmo lugar (objeto)
// //quando altera p2.nome os dois vao ser afetados ter o mesmo valor p1, p2 por fazerem o apontamento para mesma referencia.
// p2.Nome = "Vinicius";

// Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");


// int a = 10;
// int b = 1;

// Console.WriteLine($"Valor de A: {a}");
// Console.WriteLine($"Valor de B: {b}");




// // ele identifica automaticamente o tipo da propriedade, se tem " duplo, ele identifica que é um valor string
// var tipoAnonimo = new {Nome = "Patrick", Sobrenome = "Lacerda", Altura = 1.80 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);












//quando coloca ? logo apos o tipo da variavel, está informando o sistema para aceitar um valor adicionar que é do tipo nulo

//bool? desejaReceberEmail = true;

//hasvalue vai verificar se é diferente de nulo - para evitar uma excessão
// desejaReceberEmail.Value ele verifica o proprio valor se é true

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuario optou por receber e-mail.");
// }
// else
// {   
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
// }

//  string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
//  List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);// convertido arquivo jason para uma lista
//  foreach (Venda venda in listaVenda)
//  {
//      Console.WriteLine($"ID: {venda.ID}, Produto: {venda.Produto}" + 
//                        $"Preço: {venda.Preco}, Data:  {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
//  }