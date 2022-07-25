using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VagaDisponivel",
                table: "OfertaEmprego",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "LogoEmpresa",
                table: "Empresa",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "FileCV",
                table: "Candidato",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VagaDisponivel",
                table: "OfertaEmprego");

            migrationBuilder.DropColumn(
                name: "LogoEmpresa",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "FileCV",
                table: "Candidato");
        }
    }
}
