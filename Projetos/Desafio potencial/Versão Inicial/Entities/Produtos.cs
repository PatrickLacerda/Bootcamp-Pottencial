using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_potencial.Entities
{
    public class Produtos
    {
        public int Id { get; protected set; } 
        public string Produto { get; set; }
        public string Descricao { get; set; }
    }
}