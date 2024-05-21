using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tms.Server.Migrations
{
    /// <inheritdoc />
    public partial class defaultAdminAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Approval", "DateOfBirth", "Email", "FullName", "PasswordHash", "Role" },
                values: new object[] { "1", "Lahore, Pakistan", 1, new DateOnly(1998, 10, 25), "admin@gmail.com", "Admin Jani", "AQAAAAIAAYagAAAAEOsrcS7QNa6YI3IM2jnWLbxYoamz2/jUR3u+6LNAW+cfb2gwUL5CCjM55zp1wenEnw==", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
