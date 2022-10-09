using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCalculo.Entities.Configuration
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.HasData
            (
                new Contrato
                {
                    ContratoId = 1,
                    Nome = "Paulo Martins",
                    TipoNegocioId = 1,
                    Cpf_Cnpj = "08731260845",
                    Ativo = true,
                    Valor = 4683.53F,
                    DataVencimento = new DateTime(2012, 10, 9)
                },
                new Contrato
                {
                    ContratoId = 2,
                    Nome = "Carla",
                    TipoNegocioId = 2,
                    Cpf_Cnpj = "39910822849",
                    Ativo = true,
                    Valor = 7642.12F,
                    DataVencimento = new DateTime(2020, 03, 10)
                },
                new Contrato
                {
                    ContratoId = 3,
                    Nome = "Marcio",
                    TipoNegocioId = 1,
                    Cpf_Cnpj = "97816638809",
                    Ativo = true,
                    Valor = 1000.00F,
                    DataVencimento = new DateTime(2019, 01, 03)
                },
                new Contrato
                {
                    ContratoId = 4,
                    Nome = "Giovanna",
                    TipoNegocioId = 2,
                    Cpf_Cnpj = "99072483804",
                    Ativo = true,
                    Valor = 3000.00F,
                    DataVencimento = new DateTime(2019, 01, 03)
                }
            );
        }
    }
}