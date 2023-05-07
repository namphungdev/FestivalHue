using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FestivalHue.Migrations
{
    /// <inheritdoc />
    public partial class FestivalHue2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProgram_Program_ProgramId",
                table: "FavouriteProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Program_ProgramId",
                table: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_Notification_ProgramId",
                table: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_FavouriteProgram_ProgramId",
                table: "FavouriteProgram");

            migrationBuilder.AddColumn<int>(
                name: "ProgrammProgramId",
                table: "Notification",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProgrammProgramId",
                table: "FavouriteProgram",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notification_ProgrammProgramId",
                table: "Notification",
                column: "ProgrammProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteProgram_ProgrammProgramId",
                table: "FavouriteProgram",
                column: "ProgrammProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProgram_Program_ProgrammProgramId",
                table: "FavouriteProgram",
                column: "ProgrammProgramId",
                principalTable: "Program",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Program_ProgrammProgramId",
                table: "Notification",
                column: "ProgrammProgramId",
                principalTable: "Program",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteProgram_Program_ProgrammProgramId",
                table: "FavouriteProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Program_ProgrammProgramId",
                table: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_Notification_ProgrammProgramId",
                table: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_FavouriteProgram_ProgrammProgramId",
                table: "FavouriteProgram");

            migrationBuilder.DropColumn(
                name: "ProgrammProgramId",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "ProgrammProgramId",
                table: "FavouriteProgram");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_ProgramId",
                table: "Notification",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteProgram_ProgramId",
                table: "FavouriteProgram",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteProgram_Program_ProgramId",
                table: "FavouriteProgram",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Program_ProgramId",
                table: "Notification",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
