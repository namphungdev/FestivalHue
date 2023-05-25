using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FestivalHue.Migrations
{
    /// <inheritdoc />
    public partial class FestivalHue3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FavouriteProgramDto",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteProgramDto", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ProgramId",
                table: "Ticket",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Program_ProgramId",
                table: "Ticket",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Program_ProgramId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "FavouriteProgramDto");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ProgramId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Ticket");
        }
    }
}
