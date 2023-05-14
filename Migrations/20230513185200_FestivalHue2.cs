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
            migrationBuilder.DropTable(
                name: "GroupDto");

            migrationBuilder.CreateTable(
                name: "ProgramType",
                columns: table => new
                {
                    Type_program = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramType", x => x.Type_program);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Program_Type_program",
                table: "Program",
                column: "Type_program");

            migrationBuilder.AddForeignKey(
                name: "FK_Program_ProgramType_Type_program",
                table: "Program",
                column: "Type_program",
                principalTable: "ProgramType",
                principalColumn: "Type_program",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Program_ProgramType_Type_program",
                table: "Program");

            migrationBuilder.DropTable(
                name: "ProgramType");

            migrationBuilder.DropIndex(
                name: "IX_Program_Type_program",
                table: "Program");

            migrationBuilder.CreateTable(
                name: "GroupDto",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupDto", x => x.GroupId);
                });
        }
    }
}
