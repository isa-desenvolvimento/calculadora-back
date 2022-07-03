using Microsoft.EntityFrameworkCore.Migrations;

namespace calculadora_api.Migrations
{
    public partial class AddUsersToDBII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "tipoParcela",
                table: "ParceladoPre",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "modulo",
                table: "Log",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipoParcela",
                table: "ParceladoPre");

            migrationBuilder.DropColumn(
                name: "modulo",
                table: "Log");
        }
    }
}
