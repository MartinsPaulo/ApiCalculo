using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCalculo.Entities.Configuration
{
    public class TipoNegocioConfiguration : IEntityTypeConfiguration<TipoNegocio>
    {
        public void Configure(EntityTypeBuilder<TipoNegocio> builder)
        {
            builder.HasData
            (
                new TipoNegocio
                {
                    TipoNegocioid = 1,
                    Nome = "Padrão",
                },
                new TipoNegocio
                {
                    TipoNegocioid = 2,
                    Nome = "Especial",
                }
            );
        }
    }
}