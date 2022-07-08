using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.Api.Migrations
{
    public partial class identityseedwithemailconfirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87a98061-1c80-4e27-8676-829b98c07ad2", "e313d620-813a-4f99-81a6-7f0c915be69f", "Admins", "ADMINS" },
                    { "a96f16bc-9986-42cf-81ab-8029778abed7", "226a0e67-b3ac-45e1-83ef-ff201ae39032", "Users", "USERS" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "74a91dac-6380-4cd6-a31d-00381a8c94a4", 0, "c7519a2f-ed5e-4ab3-b53b-9db3d90da4d7", "user@bookstore.com", true, "User", "Bookstore", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEDi35r0fF7TGicHC9RhnjWCoq8LD0ig+c7nIkNaj2EfBbHecD74HwSaGkKcZF7hnfQ==", null, false, "34141dd0-748c-4791-934c-60e6110b2e08", false, "user@bookstore.com" },
                    { "c9b4f519-fc28-4f99-99fb-be9178a64f8d", 0, "3c0a074d-9f27-403c-bdfb-22a13d137117", "admin@bookstore.com", true, "Admin", "Bookstore", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEI6oFvIrMtnoxrUf+l2NpxEe1TPqR1lyHutiI5jJRjvfTUxdrn3mso8qKnI6+zWBIA==", null, false, "1c462e1d-4709-462d-ba50-7e5b76e9c5e7", false, "admin@bookstore.com" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
