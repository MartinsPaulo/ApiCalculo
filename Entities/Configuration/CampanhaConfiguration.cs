using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCalculo.Entities.Configuration
{
    public class CampanhaConfiguration : IEntityTypeConfiguration<Campanha>
    {
        public void Configure(EntityTypeBuilder<Campanha> builder)
        {
            builder.HasData
            (
                new Campanha
                {
                    CampanhaId = 1,
                    Nome = "Campanha Juro Simples",
                    QtdMaxPacelamento = 10,
                    TipoJuros = 'S',
                    ValorJuros = 12,
                    ValorComissaoPaschoalotto = 2
                },
                new Campanha
                {
                    CampanhaId = 2,
                    Nome = "Campanha Juro Composto",
                    QtdMaxPacelamento = 50,
                    TipoJuros = 'C',
                    ValorJuros = 10,
                    ValorComissaoPaschoalotto = 5
                }
            );
        }
    }
}