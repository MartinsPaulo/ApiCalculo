using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCalculo.Context;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalculo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CalculoController :ControllerBase
    {
        public readonly CalculoContext _context;
        public CalculoController(CalculoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CalcularDivida(int numeroParcela, int campanhaId, int contratoId)
        {
            var campanha = _context.Campanha.Find(campanhaId);
            var contrato = _context.Contrato.Find(contratoId);
            if(campanha == null || contrato == null)
                return NotFound();

            var diasAtraso =  (int)contrato.DataVencimento.Subtract(DateTime.Today).TotalDay;
            

            return Ok();
        }
        
    }
}