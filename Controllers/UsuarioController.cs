using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace primeira_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora() {

            var obj = new {

                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()

            };

            return Ok(obj);
        }

        [HttpGet("SejaBemVindo/{nome}")]
        public IActionResult SejaBemVindo(string nome) {

            var mensagem =  $"Seja Bem Vindo {nome}! Que Deus te Abençoe sempre!";

            return Ok(new {mensagem});
        }


    }
}