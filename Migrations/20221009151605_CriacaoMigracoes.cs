using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCalculo.Migrations
{
    public partial class CriacaoMigracoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Datainclusao",
                table: "TipoNegocio",
                newName: "DataInclusao");

            migrationBuilder.RenameColumn(
                name: "Dataalteracao",
                table: "TipoNegocio",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "Data_inclusao",
                table: "Contrato",
                newName: "DataVencimento");

            migrationBuilder.RenameColumn(
                name: "Data_alteracao",
                table: "Contrato",
                newName: "DataInclusao");

            migrationBuilder.RenameColumn(
                name: "Data_Vencimento",
                table: "Contrato",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "Data_inclusao",
                table: "CampanhaTipoNegocio",
                newName: "DataInclusao");

            migrationBuilder.RenameColumn(
                name: "Data_inclusao",
                table: "Campanha",
                newName: "DataInclusao");

            migrationBuilder.RenameColumn(
                name: "Data_alteracao",
                table: "Campanha",
                newName: "DataAlteracao");

            migrationBuilder.UpdateData(
                table: "Campanha",
                keyColumn: "CampanhaId",
                keyValue: 1,
                columns: new[] { "DataAlteracao", "DataInclusao" },
                values: new object[] { new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1242), new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Campanha",
                keyColumn: "CampanhaId",
                keyValue: 2,
                columns: new[] { "DataAlteracao", "DataInclusao" },
                values: new object[] { new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1245), new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "CampanhaTipoNegocio",
                keyColumn: "CampanhaTipoNegocioId",
                keyValue: 1,
                column: "DataInclusao",
                value: new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "CampanhaTipoNegocio",
                keyColumn: "CampanhaTipoNegocioId",
                keyValue: 2,
                column: "DataInclusao",
                value: new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "CampanhaTipoNegocio",
                keyColumn: "CampanhaTipoNegocioId",
                keyValue: 3,
                column: "DataInclusao",
                value: new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Contrato",
                keyColumn: "ContratoId",
                keyValue: 1,
                columns: new[] { "DataAlteracao", "DataInclusao", "DataVencimento" },
                values: new object[] { new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1385), new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1384), new DateTime(2012, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contrato",
                keyColumn: "ContratoId",
                keyValue: 2,
                columns: new[] { "DataAlteracao", "DataInclusao", "DataVencimento" },
                values: new object[] { new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1389), new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1389), new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contrato",
                keyColumn: "ContratoId",
                keyValue: 3,
                columns: new[] { "DataAlteracao", "DataInclusao", "DataVencimento" },
                values: new object[] { new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1391), new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1391), new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Contrato",
                keyColumn: "ContratoId",
                keyValue: 4,
                columns: new[] { "DataAlteracao", "DataInclusao", "DataVencimento" },
                values: new object[] { new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1393), new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1393), new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TipoNegocio",
                keyColumn: "TipoNegocioid",
                keyValue: 1,
                columns: new[] { "DataAlteracao", "DataInclusao" },
                values: new object[] { new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1094), new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "TipoNegocio",
                keyColumn: "TipoNegocioid",
                keyValue: 2,
                columns: new[] { "DataAlteracao", "DataInclusao" },
                values: new object[] { new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1098), new DateTime(2022, 10, 9, 12, 16, 4, 868, DateTimeKind.Local).AddTicks(1098) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataInclusao",
                table: "TipoNegocio",
                newName: "Datainclusao");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "TipoNegocio",
                newName: "Dataalteracao");

            migrationBuilder.RenameColumn(
                name: "DataVencimento",
                table: "Contrato",
                newName: "Data_inclusao");

            migrationBuilder.RenameColumn(
                name: "DataInclusao",
                table: "Contrato",
                newName: "Data_alteracao");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "Contrato",
                newName: "Data_Vencimento");

            migrationBuilder.RenameColumn(
                name: "DataInclusao",
                table: "CampanhaTipoNegocio",
                newName: "Data_inclusao");

            migrationBuilder.RenameColumn(
                name: "DataInclusao",
                table: "Campanha",
                newName: "Data_inclusao");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "Campanha",
                newName: "Data_alteracao");

            migrationBuilder.UpdateData(
                table: "Campanha",
                keyColumn: "CampanhaId",
                keyValue: 1,
                columns: new[] { "Data_alteracao", "Data_inclusao" },
                values: new object[] { new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3195), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Campanha",
                keyColumn: "CampanhaId",
                keyValue: 2,
                columns: new[] { "Data_alteracao", "Data_inclusao" },
                values: new object[] { new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3197), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "CampanhaTipoNegocio",
                keyColumn: "CampanhaTipoNegocioId",
                keyValue: 1,
                column: "Data_inclusao",
                value: new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "CampanhaTipoNegocio",
                keyColumn: "CampanhaTipoNegocioId",
                keyValue: 2,
                column: "Data_inclusao",
                value: new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "CampanhaTipoNegocio",
                keyColumn: "CampanhaTipoNegocioId",
                keyValue: 3,
                column: "Data_inclusao",
                value: new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Contrato",
                keyColumn: "ContratoId",
                keyValue: 1,
                columns: new[] { "Data_Vencimento", "Data_alteracao", "Data_inclusao" },
                values: new object[] { new DateTime(2012, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Contrato",
                keyColumn: "ContratoId",
                keyValue: 2,
                columns: new[] { "Data_Vencimento", "Data_alteracao", "Data_inclusao" },
                values: new object[] { new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Contrato",
                keyColumn: "ContratoId",
                keyValue: 3,
                columns: new[] { "Data_Vencimento", "Data_alteracao", "Data_inclusao" },
                values: new object[] { new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Contrato",
                keyColumn: "ContratoId",
                keyValue: 4,
                columns: new[] { "Data_Vencimento", "Data_alteracao", "Data_inclusao" },
                values: new object[] { new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3294), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "TipoNegocio",
                keyColumn: "TipoNegocioid",
                keyValue: 1,
                columns: new[] { "Dataalteracao", "Datainclusao" },
                values: new object[] { new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3041), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "TipoNegocio",
                keyColumn: "TipoNegocioid",
                keyValue: 2,
                columns: new[] { "Dataalteracao", "Datainclusao" },
                values: new object[] { new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3045), new DateTime(2022, 10, 9, 11, 46, 23, 153, DateTimeKind.Local).AddTicks(3044) });
        }
    }
}
