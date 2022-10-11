using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_fundamentos.Common.Models


{
    /// <summary>
    /// Representa uma pessoa
    /// </summary>
    public class Pessoa
    {
        ///
        public string  Nome { get; set; }
        public int Idade { get; set; }

        public string NomeRepresentanteLegalDaPessoaFisica {get ; set ;}

        /// <summary>
        /// Faz a pessoa se apresentar dizendo seu nome e idade
        /// </summary>
               
        public  void Apresentar()
        {
           
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} ");

        }

        public void CadastrarNoERPDaEmpresa() // exemplo de metodo com um nome claro de sua função 
        {

            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} ");

        }
    }
}