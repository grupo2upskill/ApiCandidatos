using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class fkteste5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoEmpresa",
                table: "Empresa");

            migrationBuilder.AddColumn<int>(
                name: "EmpresaIdEmpresa",
                table: "OfertaEmprego",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OfertaEmprego_EmpresaIdEmpresa",
                table: "OfertaEmprego",
                column: "EmpresaIdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaEmprego_Empresa_EmpresaIdEmpresa",
                table: "OfertaEmprego",
                column: "EmpresaIdEmpresa",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfertaEmprego_Empresa_EmpresaIdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropIndex(
                name: "IX_OfertaEmprego_EmpresaIdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropColumn(
                name: "EmpresaIdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.AddColumn<byte[]>(
                name: "LogoEmpresa",
                table: "Empresa",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
