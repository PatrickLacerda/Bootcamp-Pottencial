using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedade_Métodos_e_Construtores_C_.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco )
        {
            ID = id;
            Produto = produto;
            Preco = preco;
        }
        
        public int ID {get; set;}
        public int Produto {get; set;}
        public decimal Preco {get;set;}

    }
}