using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_potencial.Entities
{
    public class ItensVendidos
    {
        public int Id { get; protected set; } //Utilizado protected set para o Entity reconhecer como uma ID
        public string IndentificadorPedido { get; set; }
        public string Produto { get; set; }
        public string StatusVenda { get; set; }
        public int VendedorId { get;   set;} 
        public int VendaId { get;   set;} 
        public DateTime Data { get; set; }
    }
}