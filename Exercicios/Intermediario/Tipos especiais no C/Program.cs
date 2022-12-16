// See https://aka.ms/new-console-template for more information
using Tipos_especiais_no_C.Models;
using System.Globalization;

// // EXEMPLO DA AULA DE STACK, GEAP, GARBAGE COLLECTOR 

// Pessoa p1 = new Pessoa(nome: "Patrick", sobrenome: "Lacerda");
// //Pessoa p2 = new Pessoa (nome: "Leonardo", sobrenome: "Butta");

// Pessoa p2 = p1; // quando coloca p2 = p1 não está fazendo uma copia de P1, mas sim apontando para o mesmo lugar (objeto)
// //quando altera p2.nome os dois vao ser afetados ter o mesmo valor p1, p2 por fazerem o apontamento para mesma referencia.
// p2.Nome = "Vinicius";

// Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");


int a = 10;
int b = 1;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");




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