using System;
using Microsoft.AspNetCore.Mvc;
using WebApiJuros1.Models;
using WebApiJuros1.Repositorio;
using WebApiJuros1.Class;
namespace WebApiJuros1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class calculajurosController : Controller
    {
        private readonly IcalculajurosRepositorio _calculajurosRepositorio;
        private readonly ItaxajurosRepositorio _taxajurosRepositorio;
        public calculajurosController(IcalculajurosRepositorio calculajuros)
        {
            _calculajurosRepositorio=calculajuros;
        }
        [HttpGet]
        public IActionResult Get(decimal Valorinicial,int Tempo)
        {
            //=======================//
            //  inicio
            //=======================//
            WebApiJuros1.Controllers.taxajurosController taxajuros = new taxajurosController(_taxajurosRepositorio);
            var taxa= taxajuros.Get();
            double resultado = Convert.ToDouble(Valorinicial) * Math.Pow(Convert.ToDouble(1+ Validacoes.ResultadoJuros) , Convert.ToDouble(Tempo));
            return Ok(resultado.ToString("n2"));
        }
    }
}
