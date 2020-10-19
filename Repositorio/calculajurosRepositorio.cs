using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiJuros1.Models;
namespace WebApiJuros1.Repositorio
{
    public class calculajurosRepositorio : IcalculajurosRepositorio
    {
        public calculajuros Create(calculajuros Calculajuros)
        {
            return Calculajuros;
        }
    }
}
