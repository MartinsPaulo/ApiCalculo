using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCalculo.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campanha",
                columns: table => new
                {
                    CampanhaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdMaxPacelamento = table.Column<int>(type: "int", nullable: false),
                    TipoJuros = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ValorJuros = table.Column<float>(type: "real", nullable: false),
                    ValorComissaoPaschoalotto = table.Column<float>(type: "real", nullable: false),
                    Data_inclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_alteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campanha", x => x.CampanhaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoNegocio",
                columns: table => new
                {
                    TipoNegocioid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datainclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dataalteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNegocio", x => x.TipoNegocioid);
                });

            migrationBuilder.CreateTable(
                name: "CampanhaTipoNegocio",
                columns: table => new
                {
                    CampanhaTipoNegocioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoNegocioId = table.Column<int>(type: "int", nullable: false),
                    CampanhaId = table.Column<int>(type: "int", nullable: false),
                    Data_inclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanhaTipoNegocio", x => x.CampanhaTipoNegocioId);
                    table.ForeignKey(
                        name: "FK_CampanhaTipoNegocio_Campanha_CampanhaId",
                        column: x => x.CampanhaId,
                        principalTable: "Campanha",
                        principalColumn: "CampanhaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampanhaTipoNegocio_TipoNegocio_TipoNegocioId",
                        column: x => x.TipoNegocioId,
                        principalTable: "TipoNegocio",
                        principalColumn: "TipoNegocioid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    ContratoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoNegocioId = table.Column<int>(type: "int", nullable: false),
                    Cpf_Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Data_Vencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_inclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_alteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.ContratoId);
                    table.ForeignKey(
                        name: "FK_Contrato_TipoNegocio_TipoNegocioId",
                        column: x => x.TipoNegocioId,
                        principalTable: "TipoNegocio",
                        principalColumn: "TipoNegocioid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Campanha",
                columns: new[] { "CampanhaId", "Data_alteracao", "Data_inclusao", "Nome", "QtdMaxPacelamento", "TipoJuros", "ValorComissaoPaschoalotto", "ValorJuros" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3195), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3194), "Campanha Juro Simples", 10, "S", 2f, 12f },
                    { 2, new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3197), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3197), "Campanha Juro Composto", 50, "C", 5f, 10f }
                });

            migrationBuilder.InsertData(
                table: "TipoNegocio",
                columns: new[] { "TipoNegocioid", "Dataalteracao", "Datainclusao", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3041), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3031), "Padrão" },
                    { 2, new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3045), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3044), "Especial" }
                });

            migrationBuilder.InsertData(
                table: "CampanhaTipoNegocio",
                columns: new[] { "CampanhaTipoNegocioId", "CampanhaId", "Data_inclusao", "TipoNegocioId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3241), 1 },
                    { 2, 2, new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3242), 2 },
                    { 3, 2, new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3243), 1 }
                });

            migrationBuilder.InsertData(
                table: "Contrato",
                columns: new[] { "ContratoId", "Ativo", "Cpf_Cnpj", "Data_Vencimento", "Data_alteracao", "Data_inclusao", "Nome", "TipoNegocioId", "Valor" },
                values: new object[,]
                {
                    { 1, true, "08731260845", new DateTime(2012, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3286), "Paulo Martins", 1, 4683.53f },
                    { 2, true, "39910822849", new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3290), "Carla", 2, 7642.12f },
                    { 3, true, "97816638809", new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3292), "Marcio", 1, 1000f },
                    { 4, true, "99072483804", new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3294), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3294), "Giovanna", 2, 3000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampanhaTipoNegocio_CampanhaId",
                table: "CampanhaTipoNegocio",
                column: "CampanhaId");

            migrationBuilder.CreateIndex(
                name: "IX_CampanhaTipoNegocio_TipoNegocioId",
                table: "CampanhaTipoNegocio",
                column: "TipoNegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_TipoNegocioId",
                table: "Contrato",
                column: "TipoNegocioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampanhaTipoNegocio");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Campanha");

            migrationBuilder.DropTable(
                name: "TipoNegocio");
        }
    }
}
