using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_potencial.Entities;
using Microsoft.EntityFrameworkCore;

namespace Desafio_potencial.Context
{
    public class VendasOnlineContext :DbContext
    
    {
         public VendasOnlineContext(DbContextOptions<VendasOnlineContext>options) : base(options) // aqui onde recebe a conexão com banco
        //faz a ligação do banco de dados, vai passar para calsse pai do DbContext
        {
            
        }

        public DbSet<Vendedor> Vendedor{get;set;} // Dbset ele esta representado por uma classe e tb representado por uma tabela do banco de dados
        public DbSet<ItensVendidos> ItensVendidos{get;set;} // Dbset ele esta representado por uma classe e tb representado por uma tabela do banco de dados
        public DbSet<Produtos> Produtos{get;set;}
    }
}

