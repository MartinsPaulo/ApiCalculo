using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCalculo.Entities.Configuration
{
    public class CampanhaTipoNegocioConfiguration : IEntityTypeConfiguration<CampanhaTipoNegocio>
    {
        public void Configure(EntityTypeBuilder<CampanhaTipoNegocio> builder)
        {
            builder.HasData
            (
                new CampanhaTipoNegocio
                {
                    CampanhaTipoNegocioId = 1,
                    TipoNegocioId = 1,
                    CampanhaId = 1
                },
                new CampanhaTipoNegocio
                {
                    CampanhaTipoNegocioId = 2,
                    TipoNegocioId = 2,
                    CampanhaId = 2
                },
                new CampanhaTipoNegocio
                {
                    CampanhaTipoNegocioId = 3,
                    TipoNegocioId = 1,
                    CampanhaId = 2
                }
            );
        }
    }
}