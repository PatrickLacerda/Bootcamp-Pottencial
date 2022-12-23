using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação_orientada_a_objeto.models
{
    public abstract class Conta // significa que ela é uma classe abstrata e não pode ser usada diretamente e não pode ser herdada
    {
        protected decimal saldo; // PROTECTED -  ELE PROTEGIDO CONTRA ALTERAÇÕES EXTERNAS, POREM AS CLASSES FILHAS POSSAM ALTERAR// 
        // se usasse o comando private somente a Classe conta poderia acessar a propriedade
        public abstract void Creditar(decimal valor); // abstract todo metodo eu preciso implmentar 

        public void ExibirSaldo()
        {
            Console.WriteLine("O Seu saldo é: " + saldo);

        }
    }
}