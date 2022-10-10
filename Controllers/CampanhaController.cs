using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiCalculo.Entities;
using ApiCalculo.Context;

namespace ModuloApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CampanhaController : ControllerBase
    {
        public readonly CalculoContext _context;
        public CampanhaController(CalculoContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Campanha campanha)
        {
            _context.Add(campanha);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new {id = campanha.CampanhaId}, campanha);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId (int id)
        {
            var campanha = _context.Campanha.Find(id);
            if(campanha == null)
                return NotFound();
            return Ok(campanha);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome (string nome)
        {
            var campanhas = _context.Campanha.Where(x => x.Nome.Contains(nome));
     
            return Ok(campanhas);
        }


        [HttpPut("{id}")]
        public IActionResult Atualizar (int id, Campanha campanha)
        {
            var campanhaBanco = _context.Campanha.Find(id);

            if(campanhaBanco == null)
                return NotFound();

            campanhaBanco.Nome = campanha.Nome;
            campanhaBanco.QtdMaxPacelamento = campanha.QtdMaxPacelamento;
            campanhaBanco.TipoJuros = campanha.TipoJuros;
            campanhaBanco.ValorJuros = campanha.ValorJuros;
            campanhaBanco.ValorComissaoPaschoalotto = campanha.ValorComissaoPaschoalotto;
            campanha.DataAlteracao = DateTime.Now;

            _context.Campanha.Update(campanhaBanco);
            _context.SaveChanges();

            return Ok(campanhaBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            var campanha = _context.Campanha.Find(id);
            
            if(campanha == null)
                return NotFound();

            _context.Campanha.Remove(campanha);
            _context.SaveChanges();

            return NoContent();
        }
    }
}