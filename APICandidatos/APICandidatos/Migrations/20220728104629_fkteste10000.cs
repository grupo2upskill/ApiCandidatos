using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class fkteste10000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_OfertaEmprego_IdEmpresa",
                table: "OfertaEmprego",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropIndex(
                name: "IX_OfertaEmprego_IdEmpresa",
                table: "OfertaEmprego");

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
    }
}
