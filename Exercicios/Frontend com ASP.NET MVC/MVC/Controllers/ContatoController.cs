using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Context;
using MVC.Models;

namespace MVC.Controllers
{
    public class ContatoController : Controller
    {   

        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList(); // to list para ele transformar numa lista
            return View(contatos);
            
        }
        // TEM DOIS METODO CRIAR, QUANDO QUERO CARREGAR A PAGINA UMA VEZ, ELE VAI CARREGAR O METODO 
        // APONTANDO PARA VIEW
        //SE EU VOU CRIAR TODOS OS CAMPOS VÃO ESTA VAZIA PARA SEREM PREENCHIDO
        // A PARTIR DO MOMENTO QUE EU CLICO EM CRIAR EU VOU ENVIAR INFORMAÇÕES PARA CONTROLLER
        //QUE POR SUA VEZ EU RECEBO UM NOVO CONTATO E VOU SALVAR NO BANCO DE DADOS
        [HttpGet]
        public IActionResult Criar() // sem o http post estamos dizendo que ele é do tipo post
        {
            return View();
        }
        [HttpPost] //como ele vai receber um novo contato precisa do httppost
        // QUANDO ESTOU NA PAGINA E ENVIO O CADASTRO PARA SER  CRIADO
        public IActionResult Criar (Contato contato)
        { 
            if (ModelState.IsValid) // ELE VAI VERIFICAR SE AS INFORMAÇÕES ELAS ESTÃO VALIDAS.
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index)); // APOS SALVAR , REDIRECIONA PARA O Index
                         
            }     
            return View(contato); // se minha model não for valida, eu simplemente eu vou retornar para
            // propria pagina com os erros que ele indentificou 

        }

        [HttpGet] 
        public IActionResult Editar(int id) // sem o http post estamos dizendo que ele é do tipo post
        {
            var contato = _context.Contatos.Find(id);
            
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }
        
        [HttpPost]
        public IActionResult Editar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));


        }

        public IActionResult Detalhes(int id)
        {
            var contato = _context.Contatos.Find(id);
            
            if (contato == null)
                return RedirectToAction(nameof(Index));
            
            return View(contato);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);
            
            if (contato == null)
                return RedirectToAction(nameof(Index));
            
            return View(contato);
        }

        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


    }
}