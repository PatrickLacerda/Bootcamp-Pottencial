using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Desafio_potencial.Entities;
using Desafio_potencial.Context;

namespace Desafio_potencial.Controllers
{   
    [ApiController]  // serve para indentificar que é uma APi controller
    [Route("[controller]")] // requisito para criação de API
    public class VendasOnlineControllers :ControllerBase
    {
        private readonly VendasOnlineContext _context;

        public VendasOnlineControllers( VendasOnlineContext context)
        {
            _context = context;
        }

        [HttpGet("ObterVendedorPor{id}")]
        public IActionResult ObterVendedorPorId(int id)
        {
             var vendedor = _context.Vendedor.Find(id); //.Contatos é o nosso dbset
            if(vendedor == null) // se ele não achar ele vai retornar um NotFound
            {
                return NotFound();
            }
                    return Ok(vendedor);
        }

        [HttpPost("CadastrarVendedor")]// porque estamos enviando uma informação
        public IActionResult CadastrarVendedor(Vendedor vendedor)
        {
            _context.Add(vendedor); // adicionar no banco de dados
            _context.SaveChanges(); // salvar
            return CreatedAtAction(nameof(ObterVendedorPorId), new { id = vendedor.Id }, vendedor);
        }

        [HttpPost("CadastrarProdutos")] // porque estamos enviando uma informação
        public IActionResult CadastrarProduto(Produtos produtos)
        {   
            

            _context.Add(produtos); // adicionar no banco de dados
            _context.SaveChanges(); // salvar
            return CreatedAtAction(nameof(ObterVendedorPorId), new { id = produtos.Id }, produtos);

        }

        [HttpPost("AdicionarProdutoCarrinho")]     
        public IActionResult AdicionarCarrinho(int IdVendedor, int VendaId, ItensVendidos itensVendidos)
        {   
             var VendedorLocalizado = _context.Vendedor.Find(IdVendedor);
             //var PedidoLocalizado = _context.ItensVendidos.Find(IdVendedor);
             //var PedidoLocalizado = _context.ItensVendidos.Where(x => x.IndentificadorPedido == IndentificadorPedido);
             //var PedidoLocalizado = _context.ItensVendidos.Where(x => x.VendaId.Equals(VendaId));
            var PedidoLocalizado = _context.ItensVendidos.Where(x => x.VendaId.Equals(VendaId));

            


            //var PedidoLocalizado = _context.ItensVendidos.Find(VendaId);
            
             if (VendedorLocalizado == null)
             {
                return BadRequest(new { Erro = "Não foi Localizado Nenhum Vendedor" });    
             }
             if (PedidoLocalizado == null)
             {
                return BadRequest(new { Erro = "Não foi Localizar nenhum pedido" });    
             }

            
            itensVendidos.VendedorId = IdVendedor; 
            itensVendidos.VendaId = VendaId;

            _context.Add(itensVendidos); // adicionar no banco de dados
            _context.SaveChanges(); // salvar
            return CreatedAtAction(nameof(ObterVendedorPorId), new { id = itensVendidos.Id }, itensVendidos);
        }
        [HttpGet("VendaPor{id}")]
        public IActionResult ObterVendedaPorId(int id)
        {
             var venda = _context.ItensVendidos.Find(id); //.Contatos é o nosso dbset
             var pedidoLocalizado = _context.ItensVendidos.Where(x => x.VendaId.Equals(id));

            if(pedidoLocalizado == null) // se ele não achar ele vai retornar um NotFound
            {
                return BadRequest(new { Erro = "Não foi Localizar nenhum pedido" });  
            }
                    return Ok(
                        new
                        {
                            pedidoLocalizado,
                            venda
                        }
                    );
                    
        }   
        [HttpGet("VendaFullPor{id}")]
        public IActionResult ObterVendedaFullId(int id)
        {
             var venda = _context.ItensVendidos.Find(id); //.Contatos é o nosso dbset
             var VendedorLocalizado = _context.Vendedor.Find(venda.VendedorId);

            if(venda == null) // se ele não achar ele vai retornar um NotFound
            {
                return BadRequest(new { Erro = "Não foi Localizar nenhum pedido" });  
            }
                    return Ok(
                        new
                        {
                            
                            venda,
                            VendedorLocalizado
                        }
                    );
                    
        }             

    }
}