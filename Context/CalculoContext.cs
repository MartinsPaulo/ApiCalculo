using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiCalculo.Entities;
using ApiCalculo.Entities.Configuration;

namespace ApiCalculo.Context
{
    public class CalculoContext : DbContext
    {
        public CalculoContext(DbContextOptions<CalculoContext> options) : base(options)
        {

        }

        public DbSet<TipoNegocio> TipoNegocio { get; set; }
        public DbSet<Campanha> Campanha { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<CampanhaTipoNegocio> CampanhaTipoNegocio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoNegocioConfiguration());
            modelBuilder.ApplyConfiguration(new CampanhaConfiguration());
            modelBuilder.ApplyConfiguration(new CampanhaTipoNegocioConfiguration());
            modelBuilder.ApplyConfiguration(new ContratoConfiguration());
        }
    }
}