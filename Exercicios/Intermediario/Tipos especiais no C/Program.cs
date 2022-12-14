// See https://aka.ms/new-console-template for more information
using Tipos_especiais_no_C.Models;
using System.Globalization;


//quando coloca ? logo apos o tipo da variavel, está informando o sistema para aceitar um valor adicionar que é do tipo nulo

bool? desejaReceberEmail = true;

//hasvalue vai verificar se é diferente de nulo
// desejaReceberEmail.Value ele verifica o proprio valor se é true

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuario optou por receber e-mail.");
}
else
{   
    Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
}
