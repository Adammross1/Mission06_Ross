using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Ross.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieSubmissions",
                table: "MovieSubmissions");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MovieSubmissions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieSubmissions",
                table: "MovieSubmissions",
                column: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieSubmissions",
                table: "MovieSubmissions");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "MovieSubmissions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieSubmissions",
                table: "MovieSubmissions",
                column: "MovieId");
        }
    }
}
