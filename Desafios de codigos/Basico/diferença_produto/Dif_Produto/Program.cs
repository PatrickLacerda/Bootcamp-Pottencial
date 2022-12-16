using System.IO;
using System.Linq;
using System;

using System;

using System;

/*
Desafio
Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos. Caso contrário, retorne false. O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 

Entrada
O arquivo de entrada consiste em um inteiro n que será validada caso esteja sob as condições do desafio.

Saída
A saída consistirá em um tipo booleano: true ou false. Como nos exemplos a baixo:

Exemplo 1:

*/

using System;
 
class Solution {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
 
        for (int i = 1; i <= n; i++) {
// TODO: Crie as outras condições necessárias para a resolução do desafio:
            if (n % i ==  0) {
                count++;
            }
            if (count > 3) {
                Console.WriteLine(false);
            }
        }
         Console.WriteLine(count == 3);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        //int y = 0;

        for (int i = 1; i < n; i++)
        {
            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            //y = n;
            //y = y % i;
            // if (y == 0)
            if (n % i ==  0  )
            
            {
                count++;
            }
            if (count > 3)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        
    }
}

// namespace Introducao
// {
//     class DividindoXPorY
//     {
//         static void Main(string[] args)
//         {
//             int limit = Int32.Parse(Console.ReadLine());

//             for (int i = 0; i < limit; i++)
//             {
//                 string[] line = Console.ReadLine().Split(" ");

//                 double X = double.Parse(line[0]);
//                 double Y = double.Parse(line[1]);

//                 if (Y == 0)
//                 {
//                     Console.WriteLine("divisao impossivel");
//                 }
//                 else
//                 {
//                     double divisao = (double)X / Y;

//                     if (divisao < 0 && divisao > -0.5)
//                     {
//                         Console.WriteLine("-0.0");
//                     }
//                     else
//                     {
//                         Console.WriteLine(Math.Round(divisao, 1).ToString("N1"));
//                     }
//                 }
//             }
//         }
//     }
// }

/*

Desafio
Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

Entrada
A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.

Saída
Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

 

// */
// class encaixa {

//     static void Main(string[] args)
// {
//     int qt = int.Parse(Console.ReadLine());
//         string [] v = new  string[2];

//         // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (int i = 0; i < qt; i++)
//     {
//             v = Console.ReadLine().Split(" ");

//             string a = v[0];
//             string b = v[1];
            



//             if ( b.Length >  a.Length    )
//             Console.WriteLine("nao encaixa");
//         else if (a.EndsWith(b))
//             Console.WriteLine("encaixa");
//         else
//             Console.WriteLine("nao encaixa");

//     }

// }

// }



//Desafio um 
// using System;

// class DIO {
        
// static void Main(string[] args){

//         int numero = int.Parse(Console.ReadLine());
//         int produto = 1, somaDosDigitos = 0;
//         while (numero > 0){
//              int digito = numero % 10 ; // descobre ultimo digito;
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//              produto *= digito;
//              somaDosDigitos +=   digito  ;
//              numero /=   10   ;
//            }

//            Console.WriteLine(produto- somaDosDigitos);
//         }
//     }