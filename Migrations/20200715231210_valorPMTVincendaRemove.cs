using Microsoft.EntityFrameworkCore.Migrations;

namespace calculadora_api.Migrations
{
    public partial class valorPMTVincendaRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valorPMTVincenda",
                table: "ParceladoPre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "valorPMTVincenda",
                table: "ParceladoPre",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
