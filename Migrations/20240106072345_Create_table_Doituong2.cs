using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenVanHuan782.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Doituong2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doituong2",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<string>(type: "TEXT", nullable: false),
                    Diachi = table.Column<string>(type: "TEXT", nullable: false),
                    StudentID = table.Column<string>(type: "TEXT", nullable: false),
                    StudenID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doituong2", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Doituong2_Student_StudenID",
                        column: x => x.StudenID,
                        principalTable: "Student",
                        principalColumn: "StudentID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doituong2_StudenID",
                table: "Doituong2",
                column: "StudenID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doituong2");
        }
    }
}
