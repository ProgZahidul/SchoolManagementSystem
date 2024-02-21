using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Seedvaluadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.InsertData(
                table: "FeeType",
                columns: new[] { "FeeTypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, "Tusion Fee" },
                    { 2, "Libaray Fee" },
                    { 3, "Transfort Fee" }
                });

            migrationBuilder.InsertData(
                table: "Standard",
                columns: new[] { "StandardId", "StandardCapacity", "StandardName" },
                values: new object[,]
                {
                    { 1, null, "ClassOne" },
                    { 2, null, "ClassTwo" },
                    { 3, null, "ClassThree" }
                });

            migrationBuilder.InsertData(
                table: "FeeStructure",
                columns: new[] { "FeeStructureId", "FeeAmount", "FeePaymentId", "FeeTypeId", "Monthly", "StandardId", "Yearly" },
                values: new object[,]
                {
                    { 1, 2000m, null, 1, true, 1, false },
                    { 2, 400m, null, 2, true, 1, false },
                    { 3, 2500m, null, 1, true, 2, false },
                    { 4, 500m, null, 2, true, 2, false },
                    { 5, 2500m, null, 1, true, 3, false },
                    { 6, 500m, null, 2, true, 3, false },
                    { 7, 600m, null, 3, true, 1, false }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "AdmissionNo", "AttendanceId", "EnrollmentNo", "FatherContactNumber", "FatherNID", "FatherName", "LocalGuardianContactNumber", "LocalGuardianName", "MotherContactNumber", "MotherNID", "MotherName", "PermanentAddress", "StandardId", "StudentBloodGroup", "StudentContactNumber1", "StudentContactNumber2", "StudentCurrentAge", "StudentDOB", "StudentEamil", "StudentGender", "StudentNIDNumber", "StudentName", "StudentNationality", "StudentReligion", "TemporaryAddress" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, 1, null, null, null, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Hasan Mahmud", null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, 1, null, null, null, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Salman Khan", null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, 2, null, null, null, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Rakib Kibriya", null, null, null },
                    { 4, null, null, null, null, null, null, null, null, null, null, null, null, 2, null, null, null, 0, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Jalal Ahmed", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "FeePayment",
                columns: new[] { "FeePaymentId", "AmountAfterDiscount", "AmountPaid", "AmountRemaining", "Discount", "PaymentDate", "PreviousDue", "StudentId", "StudentName", "TotalAmount", "TotalFeeAmount" },
                values: new object[,]
                {
                    { 1, 2280m, 3000m, -720m, 5m, new DateTime(2024, 2, 14, 10, 42, 22, 787, DateTimeKind.Unspecified), 0m, 1, "Hasan Mahmud", 2280m, 2400m },
                    { 2, 2280m, 500m, 1780m, 5m, new DateTime(2024, 2, 14, 10, 42, 22, 787, DateTimeKind.Unspecified), 0m, 2, "Salman Khan", 2280m, 2400m },
                    { 3, 2280m, 500m, 1780m, 5m, new DateTime(2024, 2, 14, 10, 42, 22, 787, DateTimeKind.Unspecified), 0m, 3, "Rakib Kibriya", 2280m, 2400m }
                });

            migrationBuilder.InsertData(
                table: "FeePaymentDetail",
                columns: new[] { "FeePaymentDetailId", "FeeAmount", "FeePaymentId", "FeeTypeName" },
                values: new object[,]
                {
                    { 1, 2000m, 1, "Tusion Fee" },
                    { 2, 400m, 1, "Libaray Fee" },
                    { 3, 2000m, 2, "Tusion Fee" },
                    { 4, 400m, 2, "Libaray Fee" },
                    { 5, 2500m, 3, "Tusion Fee" },
                    { 6, 500m, 3, "Libaray Fee" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DeleteData(
                table: "FeePaymentDetail",
                keyColumn: "FeePaymentDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeePaymentDetail",
                keyColumn: "FeePaymentDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeePaymentDetail",
                keyColumn: "FeePaymentDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeePaymentDetail",
                keyColumn: "FeePaymentDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FeePaymentDetail",
                keyColumn: "FeePaymentDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FeePaymentDetail",
                keyColumn: "FeePaymentDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FeeStructure",
                keyColumn: "FeeStructureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FeePayment",
                keyColumn: "FeePaymentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeePayment",
                keyColumn: "FeePaymentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeePayment",
                keyColumn: "FeePaymentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeeType",
                keyColumn: "FeeTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeeType",
                keyColumn: "FeeTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeeType",
                keyColumn: "FeeTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Standard",
                keyColumn: "StandardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Standard",
                keyColumn: "StandardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Standard",
                keyColumn: "StandardId",
                keyValue: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "UserId", "LoginProvider", "ProviderKey" });
        }
    }
}
