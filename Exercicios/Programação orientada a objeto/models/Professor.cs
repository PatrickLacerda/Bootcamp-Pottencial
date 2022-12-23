using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação_orientada_a_objeto.models
{
    //public sealed class Professor : Pessoa  // quando se utiliza a palavra sealed, significa que a classe está selada para herança 
    public  class Professor : Pessoa
    {   
        public Professor()
        {

        }
        public Professor(string nome) : base(nome) // quando se cria um construtor na classe pai, as filhas precisam criar contrutor 
        // com o contrutor eu estou exigindo o nome e quando utilizo :base(nome) esta recebendo o nome e passando para classe pai nome
        {
            
        }
        public double Salario { get; set; }

        //public sealed override void Apresentar() // sealed , como  o metodos apresentar é selado , a classe diretor acaba dando erro porque não pode herdar
        public  override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} e sou professor e ganho {Salario}");
        }
    }

    
}