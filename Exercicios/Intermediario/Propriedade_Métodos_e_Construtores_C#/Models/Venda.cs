using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Propriedade_Métodos_e_Construtores_C_.Models
{
    public class Venda
    {
        public int ID {get; set;}
        [JsonProperty("Nome_Produto")] //o meu objeto tem o nome produto, mas vai vir Nome_Produto do arquivo.json
        //[] quando tem a chave abre e fecha cochete, significa passando um determinado comportamento para sua propriedade ou classe
        public string Produto {get; set;}
        public decimal Preco {get;set;}
        public DateTime DataVenda{get;set;}

        public Venda(int id, string produto, decimal preco, DateTime datavenda ) // construtor
        {
            ID = id;
            Produto = produto;
            Preco = preco;
            DataVenda = datavenda;
        }
        
        

    }
}