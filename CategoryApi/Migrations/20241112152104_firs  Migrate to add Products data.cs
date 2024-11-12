using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CategoryApi.Migrations
{
    /// <inheritdoc />
    public partial class firsMigratetoaddProductsdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Bánh kem, bánh kem bắp, bánh kem nhân mứt", "Bánh kem" },
                    { 2, "Bánh mì, bánh quy, donut", "Bánh nướng" },
                    { 3, "Bánh flan, bánh su kem, pudding ", "Bánh lạnh" },
                    { 4, "Kem vani, kem đậu xanh, kem dâu, kem chuối", "Cà rem" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Images", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "/images/Banh-Kem-Dau-1.jpg", "Bánh kem nhân dâu", 335.000m },
                    { 2, 1, "/images/Banh-Kem-Bap-1-2.jpg", "Bánh kem bắp", 335.000m },
                    { 3, 1, "/images/Banh-Kem-Thom-10-1.jpg", "Bánh kem nhân mứt", 335.000m },
                    { 4, 2, "/images/sandwich-ngu-coc.jpg", "Bánh mì", 23.000m },
                    { 5, 2, "/images/Quy-Bo-Dau-Phong.jpg", "Bánh quy", 25.000m },
                    { 6, 2, "/images/Banh-Donut.jpg", "Bánh donut", 15.000m },
                    { 7, 3, "/images/Banh-Flan-2.jpg", "Bánh flan", 12.000m },
                    { 8, 3, "/images/banh_su_kem.jpg", "Bánh su kem", 33.000m },
                    { 9, 3, "/images/pudding-xoai.jpg", "Pudding", 35.000m },
                    { 10, 4, "/images/Kem-Vani.jpg", "Kem vani", 13.000m },
                    { 11, 4, "/images/Kem-Dau-Xanh.jpg", "Kem đậu xanh", 13.000m },
                    { 12, 4, "/images/Kem-Dau.jpg", "Kem dâu", 13.000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
