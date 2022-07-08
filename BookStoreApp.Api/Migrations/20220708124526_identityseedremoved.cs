using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.Api.Migrations
{
    public partial class identityseedremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a96f16bc-9986-42cf-81ab-8029778abed7", "74a91dac-6380-4cd6-a31d-00381a8c94a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "87a98061-1c80-4e27-8676-829b98c07ad2", "c9b4f519-fc28-4f99-99fb-be9178a64f8d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87a98061-1c80-4e27-8676-829b98c07ad2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a96f16bc-9986-42cf-81ab-8029778abed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74a91dac-6380-4cd6-a31d-00381a8c94a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9b4f519-fc28-4f99-99fb-be9178a64f8d");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87a98061-1c80-4e27-8676-829b98c07ad2", "d0faaf98-d2e4-4c66-9ce7-2109b6f9304f", "Admins", "ADMINS" },
                    { "a96f16bc-9986-42cf-81ab-8029778abed7", "1488b16b-f72f-44ed-a181-dde25b2c26b9", "Users", "USERS" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "74a91dac-6380-4cd6-a31d-00381a8c94a4", 0, "20c00623-aec7-4a46-8b9e-b978d8153e56", "user@bookstore.com", false, "User", "Bookstore", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAENfPedMf4IQgmOdBOKL69fDK9jb5e3yV//V1HplAOYxsosYHsZOeh3Hm4cqrofRRvw==", null, false, "68a1dfc2-38f0-456b-a368-72c3539b7401", false, "user@bookstore.com" },
                    { "c9b4f519-fc28-4f99-99fb-be9178a64f8d", 0, "0b32e51b-ea04-4abb-a565-e53d75b2583c", "admin@bookstore.com", false, "Admin", "Bookstore", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEAVEFG9kHLHARoKuXdKYNJP4vX13UUNcVygUU9mZ4aE8XxKBUtJBxsCNW0AoPsVPZg==", null, false, "68d32973-dd8d-473e-b617-451d827522d4", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a96f16bc-9986-42cf-81ab-8029778abed7", "74a91dac-6380-4cd6-a31d-00381a8c94a4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "87a98061-1c80-4e27-8676-829b98c07ad2", "c9b4f519-fc28-4f99-99fb-be9178a64f8d" });
        }
    }
}
