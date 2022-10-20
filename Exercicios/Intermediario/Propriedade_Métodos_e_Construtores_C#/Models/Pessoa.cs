using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedade_Métodos_e_Construtores_C_.Models

// public qualquer um pode acessar a sua class ou instanciar a classe

{
    public class Pessoa
    {   
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome) // todo construtor vai ter o mesmo nome da sua classe e não tem um tipo de retorno
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome; // private só é permitido acessar dentro da propria classe - Campo um valor que vai armazenar o nome
        public string  Nome // public  qualquer um pode acessar a propridade 
        { 
            get => _nome.ToUpper(); // => deixa o codigo mais limpo, retornando valores da variavel ( Body Expression)
            // quando tem get ou set é uma propriedade
            // get
            // {
            //     return _nome.ToUpper(); //ToUpperconverter o nome para maiuculo 
            // }

            set
            {
                if (value == "") // value é o argumento que está recebendo o nome 
                {
                    throw new ArgumentException("O nome não pode ser vazio");// throw não permite que o codigo continue / exception

                
                }

                _nome = value; // pode ser usado set => _nome = value; 
            } 
        }    


        public string  Sobrenome { get; set; }

        public string  NomeCompleto => $"{Nome} { Sobrenome}".ToUpper() ; // combinar propriedades em uma unica propriedade, somente leitura, sem o Set
         
         private int _idade;
        public int Idade
         { 
            
            get => _idade;
            
            set
            {
                if (value <0) 
                {
                    throw new ArgumentException ("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
         
         
         }

        

        public void Apresentar()
        {
            Console.Write($"NOME: {NomeCompleto}, Idade: {Idade}");
        }

       

    }
} 