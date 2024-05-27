using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeProject.Migrations
{
    /// <inheritdoc />
    public partial class updatedataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { "Dingo/img/food_item/food_item_1.png", new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { "Dingo/img/food_item/food_item_1.png", new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { "Dingo/img/food_item/food_item_1.png", new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { "Dingo/img/food_item/food_item_1.png", new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { "Dingo/img/food_item/food_item_1.png", new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { "Dingo/img/food_item/food_item_1.png", new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5772) });

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
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5801), "Dingo/img/food_item/food_item_2.png" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5804), "Dingo/img/food_item/food_item_2.png" });

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

            migrationBuilder.InsertData(
                table: "Visacards",
                columns: new[] { "id", "Cardnumber", "CreatedBy", "CreatedDate", "Cvv", "Expirydate", "Firstname", "IsDeleted", "Lastname", "ModifiedBy", "ModifiedDate", "Pin", "UserId" },
                values: new object[] { 1, 1234131L, null, new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5842), "123", "01/27", "User", false, "User", null, null, (byte)101, 1 });

            migrationBuilder.UpdateData(
                table: "Websitedetails",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 27, 16, 2, 52, 106, DateTimeKind.Local).AddTicks(5858));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Visacards",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "CategoryImagePath", "CreatedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipecategories",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipepayments",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipepayments",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { null, "fdsfds" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { null, "fdfdsfsf" });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Userroles",
                keyColumn: "id",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Websitedetails",
                keyColumn: "id",
                keyValue: 1,
                column: "CreatedDate",
                value: null);
        }
    }
}
