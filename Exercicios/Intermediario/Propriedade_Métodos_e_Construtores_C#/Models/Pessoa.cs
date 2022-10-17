using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedade_Métodos_e_Construtores_C_.Models
{
    public class Pessoa
    {   
        private string _nome;
        public string  Nome 
        { 
            get => _nome.ToUpper(); // => deixa o codigo mais limpo, retornando valores da variavel
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

                _nome = value;
            } 
        }    
         
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.Write($"NOME: {Nome}, Idade: {Idade}");
        }

       

    }
} 