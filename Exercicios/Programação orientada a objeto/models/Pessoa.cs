using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação_orientada_a_objeto.models
{
    public class Pessoa
    {    

        // quando se tem um construtor com mesmo nome( Pessoa), eu posso instansiar uma ou outra 
        public Pessoa()
        {

        }
        public Pessoa (string nome)  //CONSTRUTOR 
        {
            Nome = nome ;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() // a palavra virtual,  significa que esse metodo pode ser sobrescrito se a classe assim desejar(Polimorfirmo)
        {
        Console.WriteLine($" Olá, meu nome é {Nome} e tenho {Idade} !");
        }


    }


}