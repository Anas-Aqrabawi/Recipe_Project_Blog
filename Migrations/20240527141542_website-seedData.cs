using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecipeProject.Migrations
{
    /// <inheritdoc />
    public partial class websiteseedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Recipepayments",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Recipepayments",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Visacards",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Websitedetails",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Websitetext" },
                values: new object[] { new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3669), "Welcome to Recipe Blog\r\nDelivering great food for more than 18 years!" });

            migrationBuilder.InsertData(
                table: "Websitedetails",
                columns: new[] { "id", "AdminId", "CreatedBy", "CreatedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Texttype", "Websitetext" },
                values: new object[,]
                {
                    { 2, 1, null, new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3670), false, null, null, 3, "Contact Us" },
                    { 3, 1, null, new DateTime(2024, 5, 27, 17, 15, 42, 745, DateTimeKind.Local).AddTicks(3671), false, null, null, 2, "A108 Adam Street, New York, NY 535022" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Websitedetails",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Websitedetails",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Recipepayments",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Recipepayments",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Visacards",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Websitedetails",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Websitetext" },
                values: new object[] { new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5858), "home page details" });
        }
    }
}
