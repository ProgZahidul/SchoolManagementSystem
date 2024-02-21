using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateseedval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 1,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { "ClassOne", "Tusion Fee" });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 2,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { "ClassOne", "Libaray Fee" });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 3,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { "ClassTwo", "Tusion Fee" });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 4,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { "ClassTwo", "Libaray Fee" });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 5,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { "ClassThree", "Tusion Fee" });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 6,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { "ClassThree", "Libaray Fee" });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 7,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { "ClassOne", "Transfort Fee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 1,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 2,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 3,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 4,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 5,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 6,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 7,
                columns: new[] { "StandardName", "TypeName" },
                values: new object[] { null, null });
        }
    }
}
