using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculo.Entities
{
    public class TipoNegocio
    {
        public int TipoNegocioid { get; set; }
        public string Nome { get; set; }
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

    }
    
}