using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação_orientada_a_objeto.models

// PARA TRABALHAR COM HERANÇA, APÓS A CLASSE COLOCAR : E DEPOIS A CLASSE QUE QUER HERDAR
{
    public class Aluno : Pessoa
    {   
        public Aluno()
        {
            
        }
        public Aluno(string nome) :base(nome)
        {

        }
        public double Nota { get; set; }

        public override void Apresentar() // Palavra override  utilizar o polemorfismo
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade}, e sou um aluno nota {Nota}");
        }
    }
}