using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculo.Entities
{
    public class CampanhaTipoNegocio
    {
        public int CampanhaTipoNegocioId { get; set; }
        public int TipoNegocioId { get; set; }
        public  TipoNegocio TipoNegocio { get; set; }
        public int CampanhaId { get; set; }
        public  Campanha Campanha { get; set; }
        public DateTime DataInclusao { get; set; } = DateTime.Now;
    }
}