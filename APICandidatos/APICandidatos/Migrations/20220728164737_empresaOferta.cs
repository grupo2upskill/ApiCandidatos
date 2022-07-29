using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICandidatos.Migrations
{
    public partial class empresaOferta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego");

            migrationBuilder.DropIndex(
                name: "IX_OfertaEmprego_IdEmpresa",
                table: "OfertaEmprego");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OfertaEmprego_IdEmpresa",
                table: "OfertaEmprego",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_OfertaEmprego_Empresa_IdEmpresa",
                table: "OfertaEmprego",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
