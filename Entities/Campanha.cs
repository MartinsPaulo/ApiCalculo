using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalculo.Entities
{
    public class Campanha
    {
        public int CampanhaId { get; set; }
        public string Nome { get; set; }
        public int QtdMaxPacelamento { get; set; }
        public char TipoJuros { get; set; } //S ou C(simples ou composto)
        public float ValorJuros { get; set; }
        public float ValorComissaoPaschoalotto { get; set; }
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;        
    }
}