using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJuros1.Class;
using WebApiJuros1.Models;
using WebApiJuros1.Repositorio;

namespace WebApiJuros1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class taxajurosController : Controller
    {
        private readonly ItaxajurosRepositorio _taxajurosRepositorio;

        public taxajurosController(ItaxajurosRepositorio taxajuros)
        {
            _taxajurosRepositorio = taxajuros;
        }

        [HttpGet]
        public IActionResult Get()
        {
          
            Validacoes.ResultadoJuros = 0.01;
            return Ok(0.01) ;
        }

    }
}
