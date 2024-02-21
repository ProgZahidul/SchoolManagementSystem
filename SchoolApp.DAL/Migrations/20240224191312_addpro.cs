using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addpro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StandardName",
                table: "FeeStructure",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Typenmae",
                table: "FeeStructure",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 1,
                columns: new[] { "StandardName", "Typenmae" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 2,
                columns: new[] { "StandardName", "Typenmae" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 3,
                columns: new[] { "StandardName", "Typenmae" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 4,
                columns: new[] { "StandardName", "Typenmae" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 5,
                columns: new[] { "StandardName", "Typenmae" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 6,
                columns: new[] { "StandardName", "Typenmae" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 7,
                columns: new[] { "StandardName", "Typenmae" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StandardName",
                table: "FeeStructure");

            migrationBuilder.DropColumn(
                name: "Typenmae",
                table: "FeeStructure");
        }
    }
}
