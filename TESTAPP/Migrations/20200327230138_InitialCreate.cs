using Microsoft.EntityFrameworkCore.Migrations;

namespace TESTAPP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    doctor_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctorFirstName = table.Column<string>(nullable: true),
                    doctorMidName = table.Column<string>(nullable: true),
                    doctorLastName = table.Column<string>(nullable: true),
                    internship = table.Column<int>(nullable: false),
                    speciality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.doctor_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
