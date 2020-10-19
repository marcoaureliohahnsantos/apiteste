using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiJuros1.Class
{
    public class Validacoes
    {
        /// <summary>
        /// 
        /// </summary>
        protected static Double resultadoJuros;
        public static Double ResultadoJuros
        {
           
            get { return resultadoJuros; }
            set { resultadoJuros = value; }
        
        }
    }
}
