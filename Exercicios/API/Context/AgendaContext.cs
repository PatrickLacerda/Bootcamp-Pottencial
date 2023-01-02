using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; // classe importada dbcontext
using API.Entities;
namespace API.Context
{
    public class AgendaContext :DbContext // importar a classe dbcontext
    {
        public AgendaContext(DbContextOptions<AgendaContext>options) : base(options) // aqui onde recebe a conexão com banco
        //faz a ligação do banco de dados, vai passar para calsse pai do DbContext
        {
            
        }

        public DbSet<Contato> Contatos{get;set;} // Dbset ele esta representado por uma classe e tb representado por uma tabela do banco de dados
    }
}