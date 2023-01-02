using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


 

namespace API.Controllers
{
    [ApiController]  // serve para indentificar que é uma APi controller
    [Route("[controller]")] // requisito para criação de API
    public class UsuarioController : ControllerBase // no cmainho http ele ignorar o controller e o caminho fica apenas
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObeterDataHora() // action result para retorna algo uma ação
        {
            var obj = new 
            {
                data = DateTime.Now.ToLongDateString(), // retorna data
                hora = DateTime.Now.ToShortDateString()// retorna hora 

            };

            return Ok(obj);

        }
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo";
            return Ok(new {mensagem});
        }
    }
}