using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [ApiController]  // serve para indentificar que é uma APi controller
    [Route("[controller]")] // requisito para criação de API
    public class ContatoController :ControllerBase
    {
        // colocar os end point que queremos que nossa API tenha
        private readonly AgendaContext _context; // um atributo privado somente leitura readonly
        // _context é uma variavel ou um nome 
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]// porque estamos enviando uma informação
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato); // adicionar no banco de dados
            _context.SaveChanges(); // salvar
            //return Ok(contato);
            // estou dizendo após criar , para obter o registro recem criado, você pode chamar o nameof(ObterPorID)
            // estou retornando o id recem criado new {id = contato.Id} e a propria informação do contato ,contato)
            return CreatedAtAction(nameof(ObterPorID), new {id = contato.Id},contato);// informa a rota que o usuario pode tomar apos criar uusario
        }
        [HttpGet("{id}")] // estou informando que ele vai receber uma ID
        public IActionResult ObterPorID(int id) //LOCALIZAR UM CONTATO POR ID
        {
            var contato = _context.Contatos.Find(id); //.Contatos é o nosso dbset
            if(contato == null) // se ele não achar ele vai retornar um NotFound
            {
                return NotFound();
            }

            return Ok(contato);
        }
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {   //(x => x.Nome.Contains(nome)) - x => não é uma operador logico mas sintaxy
            //Contatos onde o nome do contato contenha o nome que estou passando por parametro
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null)
            {
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            return Ok(contatoBanco);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
             var contatoBanco = _context.Contatos.Find(id);
            if (contatoBanco == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges(); // ele salva suas alterações
            return NoContent();// retorna um sem conteudo, porque deletou um arquivo

        }

    }
}