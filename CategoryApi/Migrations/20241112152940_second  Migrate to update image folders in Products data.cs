using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CategoryApi.Migrations
{
    /// <inheritdoc />
    public partial class secondMigratetoupdateimagefoldersinProductsdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Images",
                value: "/images/cakes/Banh-Kem-Dau-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Images",
                value: "/images/cakes/Banh-Kem-Bap-1-2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Images",
                value: "/images/cakes/Banh-Kem-Thom-10-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Images",
                value: "/images/baked-cakes/sandwich-ngu-coc.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Images",
                value: "/images/baked-cakes/Quy-Bo-Dau-Phong.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Images",
                value: "/images/baked-cakes/Banh-Donut.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Images",
                value: "/images/cold-cakes/Banh-Flan-2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Images",
                value: "/images/cold-cakes/banh_su_kem.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Images",
                value: "/images/cold-cakes/pudding-xoai.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Images",
                value: "/images/ice-cream/Kem-Vani.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Images",
                value: "/images/ice-cream/Kem-Dau-Xanh.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Images",
                value: "/images/ice-cream/Kem-Dau.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Images",
                value: "/images/Banh-Kem-Dau-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Images",
                value: "/images/Banh-Kem-Bap-1-2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Images",
                value: "/images/Banh-Kem-Thom-10-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Images",
                value: "/images/sandwich-ngu-coc.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Images",
                value: "/images/Quy-Bo-Dau-Phong.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Images",
                value: "/images/Banh-Donut.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Images",
                value: "/images/Banh-Flan-2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Images",
                value: "/images/banh_su_kem.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Images",
                value: "/images/pudding-xoai.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Images",
                value: "/images/Kem-Vani.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Images",
                value: "/images/Kem-Dau-Xanh.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Images",
                value: "/images/Kem-Dau.jpg");
        }
    }
}
