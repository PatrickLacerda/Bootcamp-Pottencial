// See https://aka.ms/new-console-template for more information
using Exemplo_fundamentos.Common.Models ;
using ExemploFundamento.OperadoresAritimeticos.Common.models ;
//Console.WriteLine("Hello, World!");




//Instacia da classe pessoa
 Pessoa p = new Pessoa();
 Calculadora Calc = new Calculadora();

// Atribui o nome e idade para pessoa
p.Nome = "Patrick";
p.Idade = 20;
/*
comentario de multiplas linhas 
*/
// Faz a pessoa se apresentar
p.Apresentar();
p.CadastrarNoERPDaEmpresa();
Calc.Somar(3,5);
Calc.Subtrair(3,5);
// ESTUDANDO O COMANDO LISTA 

List<string> listaString = new List<string>();

 listaString.Add("SP");
 listaString.Add("BA");
 listaString.Add("MG");
 listaString.Add("RJ");
Console.WriteLine($"Itens na minha lista: {listaString.Count}- Capacidade : {listaString.Capacity} ");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count}- Capacidade : {listaString.Capacity} ");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count}- Capacidade : {listaString.Capacity} ");

// Console.WriteLine("Percorrendo a lista com o FOR");
//  for(int contador = 0; contador < listaString.Count; contador++)
//  {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
//  }


//  Console.WriteLine("Percorrendo a lista com o FOREACH");
//  int contadorForeach = 0 ;

//  foreach (string item in listaString)
//  {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//  }


// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 72 ;
// arrayInteiros[1] = 64 ;
// arrayInteiros[2] = 50 ;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2] ;
// Array.Copy(arrayInteiros , arrayInteirosDobrado, arrayInteiros.Length); // copia um array para outro
 
//  Array.Resize(ref arrayInteiros, arrayInteiros.Length + 1 );/// aumenta o tamanho do array com valor estipulado

// Console.WriteLine("Percorrento o Array com o FOR");

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("Percorrendo o Array com o FOREACH");



// int contadorForeach = 0;


// foreach (int valor in arrayInteiros)
// {
//     //Console.WriteLine(valor);
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }