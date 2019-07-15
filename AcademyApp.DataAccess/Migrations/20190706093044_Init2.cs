using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyApp.DataAccess.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "TypeOfAcademy" },
                values: new object[] { 1, 25, "Bob", "Bobsky", 0 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "TypeOfAcademy" },
                values: new object[] { 2, 26, "Jill", "Wayne", 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "TypeOfAcademy" },
                values: new object[] { 3, 27, "John", "Johnson", 2 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "EstimatedTime", "StudentId", "TimeSpend", "Title" },
                values: new object[,]
                {
                    { 1, 30, 1, 25, "JavaProject" },
                    { 2, 80, 1, 75, "HrApp" },
                    { 3, 30, 2, 25, "MVCProject" },
                    { 4, 40, 2, 35, "MyProject" },
                    { 5, 50, 3, 45, "JavaScriptProject" },
                    { 6, 60, 3, 55, "C#Project" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
