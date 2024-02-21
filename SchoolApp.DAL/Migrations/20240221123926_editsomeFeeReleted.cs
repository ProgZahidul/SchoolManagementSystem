using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class editsomeFeeReleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeeTypeId",
                table: "FeePaymentDetail");

            migrationBuilder.AddColumn<string>(
                name: "FeeTypeName",
                table: "FeePaymentDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentName",
                table: "FeePayment",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeeTypeName",
                table: "FeePaymentDetail");

            migrationBuilder.DropColumn(
                name: "StudentName",
                table: "FeePayment");

            migrationBuilder.AddColumn<int>(
                name: "FeeTypeId",
                table: "FeePaymentDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
