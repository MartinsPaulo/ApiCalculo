using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ApiCalculo.Entities;

namespace ApiCalculo.Entities
{
    public class Contrato
    {
        public int ContratoId { get; set; } // Primary key
        public string Nome { get; set; }
        public int TipoNegocioId { get; set; }
        public TipoNegocio TipoNegocio { get; set; }
        public string Cpf_Cnpj { get; set; }
        public bool Ativo { get; set; }
        public float Valor { get; set; }       
        public DateTime DataVencimento { get; set; }
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}