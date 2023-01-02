using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Contato
    {   
        
        public int Id { get; protected set; } //Utilizado protected set para o Entity reconhecer como uma ID
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}