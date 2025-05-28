using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projexor.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDeploy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    Login = table.Column<string>(type: "Nvarchar(30)", nullable: false),
                    PasswordHash = table.Column<string>(type: "NVarchar(64)", nullable: false),
                    Email = table.Column<string>(type: "Nvarchar(254)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "Nvarchar(20)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "SmallDateTime", nullable: false),
                    CreatAt = table.Column<DateTime>(type: "SmallDateTime", nullable: false),
                    Active = table.Column<bool>(type: "Bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "Unique_Key_Email_UserAccount",
                table: "UserAccount",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Unique_Key_Login_UserAccount",
                table: "UserAccount",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Unique_Key_PhoneNumber_UserAccount",
                table: "UserAccount",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccount");
        }
    }
}
