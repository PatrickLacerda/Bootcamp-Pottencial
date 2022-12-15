// See https://aka.ms/new-console-template for more information
using Tipos_especiais_no_C.Models;
using System.Globalization;

// ele identifica automaticamente o tipo da propriedade, se tem " duplo, ele identifica que é um valor string
var tipoAnonimo = new {Nome = "Patrick", Sobrenome = "Lacerda", Altura = 1.80 };

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);












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