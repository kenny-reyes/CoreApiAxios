using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gender = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    species = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "id", "gender", "image", "name", "species" },
                values: new object[] { 1, "male", "https://rickandmortyapi.…/character/avatar/1.jpeg", "Rick", "human" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
