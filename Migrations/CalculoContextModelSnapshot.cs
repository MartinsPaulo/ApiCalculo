﻿// <auto-generated />
using System;
using ApiCalculo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiCalculo.Migrations
{
    [DbContext(typeof(CalculoContext))]
    partial class CalculoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiCalculo.Entities.Campanha", b =>
                {
                    b.Property<int>("CampanhaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampanhaId"), 1L, 1);

                    b.Property<DateTime>("Data_alteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_inclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdMaxPacelamento")
                        .HasColumnType("int");

                    b.Property<string>("TipoJuros")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<float>("ValorComissaoPaschoalotto")
                        .HasColumnType("real");

                    b.Property<float>("ValorJuros")
                        .HasColumnType("real");

                    b.HasKey("CampanhaId");

                    b.ToTable("Campanha");

                    b.HasData(
                        new
                        {
                            CampanhaId = 1,
                            Data_alteracao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3195),
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3194),
                            Nome = "Campanha Juro Simples",
                            QtdMaxPacelamento = 10,
                            TipoJuros = "S",
                            ValorComissaoPaschoalotto = 2f,
                            ValorJuros = 12f
                        },
                        new
                        {
                            CampanhaId = 2,
                            Data_alteracao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3197),
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3197),
                            Nome = "Campanha Juro Composto",
                            QtdMaxPacelamento = 50,
                            TipoJuros = "C",
                            ValorComissaoPaschoalotto = 5f,
                            ValorJuros = 10f
                        });
                });

            modelBuilder.Entity("ApiCalculo.Entities.CampanhaTipoNegocio", b =>
                {
                    b.Property<int>("CampanhaTipoNegocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampanhaTipoNegocioId"), 1L, 1);

                    b.Property<int>("CampanhaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_inclusao")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipoNegocioId")
                        .HasColumnType("int");

                    b.HasKey("CampanhaTipoNegocioId");

                    b.HasIndex("CampanhaId");

                    b.HasIndex("TipoNegocioId");

                    b.ToTable("CampanhaTipoNegocio");

                    b.HasData(
                        new
                        {
                            CampanhaTipoNegocioId = 1,
                            CampanhaId = 1,
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3241),
                            TipoNegocioId = 1
                        },
                        new
                        {
                            CampanhaTipoNegocioId = 2,
                            CampanhaId = 2,
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3242),
                            TipoNegocioId = 2
                        },
                        new
                        {
                            CampanhaTipoNegocioId = 3,
                            CampanhaId = 2,
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3243),
                            TipoNegocioId = 1
                        });
                });

            modelBuilder.Entity("ApiCalculo.Entities.Contrato", b =>
                {
                    b.Property<int>("ContratoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContratoId"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Cpf_Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_Vencimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_alteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_inclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoNegocioId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("ContratoId");

                    b.HasIndex("TipoNegocioId");

                    b.ToTable("Contrato");

                    b.HasData(
                        new
                        {
                            ContratoId = 1,
                            Ativo = true,
                            Cpf_Cnpj = "08731260845",
                            Data_Vencimento = new DateTime(2012, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Data_alteracao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3286),
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3286),
                            Nome = "Paulo Martins",
                            TipoNegocioId = 1,
                            Valor = 4683.53f
                        },
                        new
                        {
                            ContratoId = 2,
                            Ativo = true,
                            Cpf_Cnpj = "39910822849",
                            Data_Vencimento = new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Data_alteracao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3291),
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3290),
                            Nome = "Carla",
                            TipoNegocioId = 2,
                            Valor = 7642.12f
                        },
                        new
                        {
                            ContratoId = 3,
                            Ativo = true,
                            Cpf_Cnpj = "97816638809",
                            Data_Vencimento = new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Data_alteracao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3292),
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3292),
                            Nome = "Marcio",
                            TipoNegocioId = 1,
                            Valor = 1000f
                        },
                        new
                        {
                            ContratoId = 4,
                            Ativo = true,
                            Cpf_Cnpj = "99072483804",
                            Data_Vencimento = new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Data_alteracao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3294),
                            Data_inclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3294),
                            Nome = "Giovanna",
                            TipoNegocioId = 2,
                            Valor = 3000f
                        });
                });

            modelBuilder.Entity("ApiCalculo.Entities.TipoNegocio", b =>
                {
                    b.Property<int>("TipoNegocioid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoNegocioid"), 1L, 1);

                    b.Property<DateTime>("Dataalteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datainclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoNegocioid");

                    b.ToTable("TipoNegocio");

                    b.HasData(
                        new
                        {
                            TipoNegocioid = 1,
                            Dataalteracao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3041),
                            Datainclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3031),
                            Nome = "Padrão"
                        },
                        new
                        {
                            TipoNegocioid = 2,
                            Dataalteracao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3045),
                            Datainclusao = new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3044),
                            Nome = "Especial"
                        });
                });

            modelBuilder.Entity("ApiCalculo.Entities.CampanhaTipoNegocio", b =>
                {
                    b.HasOne("ApiCalculo.Entities.Campanha", "Campanha")
                        .WithMany()
                        .HasForeignKey("CampanhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiCalculo.Entities.TipoNegocio", "TipoNegocio")
                        .WithMany()
                        .HasForeignKey("TipoNegocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campanha");

                    b.Navigation("TipoNegocio");
                });

            modelBuilder.Entity("ApiCalculo.Entities.Contrato", b =>
                {
                    b.HasOne("ApiCalculo.Entities.TipoNegocio", "TipoNegocio")
                        .WithMany()
                        .HasForeignKey("TipoNegocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoNegocio");
                });
#pragma warning restore 612, 618
        }
    }
}
