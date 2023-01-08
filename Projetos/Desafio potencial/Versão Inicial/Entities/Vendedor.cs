using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_potencial.Entities
{
    public class Vendedor
    {
        public int Id { get; protected set; } //Utilizado protected set para o Entity reconhecer como uma ID
        public string Nome { get; set; }
        public string E_mail { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
    }
}