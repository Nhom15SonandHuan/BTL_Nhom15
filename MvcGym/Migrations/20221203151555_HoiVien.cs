using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcGym.Migrations
{
    /// <inheritdoc />
    public partial class HoiVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<string>(type: "TEXT", nullable: false),
                    TenChucVu = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "GiaGoi",
                columns: table => new
                {
                    MaGiaGoi = table.Column<string>(type: "TEXT", nullable: false),
                    TenGoi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaGoi", x => x.MaGiaGoi);
                });

            migrationBuilder.CreateTable(
                name: "HoiVien",
                columns: table => new
                {
                    HoiVienID = table.Column<string>(type: "TEXT", nullable: false),
                    TenHV = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    SĐT = table.Column<string>(type: "TEXT", nullable: false),
                    EmailHV = table.Column<string>(type: "TEXT", nullable: false),
                    GoiTap = table.Column<string>(type: "TEXT", nullable: true),
                    Ngaybatdau = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ngayketthuc = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoiVien", x => x.HoiVienID);
                });

            migrationBuilder.CreateTable(
                name: "ThietBi",
                columns: table => new
                {
                    MaTB = table.Column<string>(type: "TEXT", nullable: false),
                    TenTB = table.Column<string>(type: "TEXT", nullable: false),
                    size = table.Column<int>(type: "INTEGER", nullable: false),
                    Soluong = table.Column<int>(type: "INTEGER", nullable: false),
                    Giatien = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBi", x => x.MaTB);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaID = table.Column<string>(type: "TEXT", nullable: false),
                    TenNV = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    SĐT = table.Column<string>(type: "TEXT", nullable: false),
                    EmailNV = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    MaChucVu = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaID);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoiTap",
                columns: table => new
                {
                    GoiID = table.Column<string>(type: "TEXT", nullable: false),
                    MaGoiTap = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoiTap", x => x.GoiID);
                    table.ForeignKey(
                        name: "FK_GoiTap_GiaGoi_MaGoiTap",
                        column: x => x.MaGoiTap,
                        principalTable: "GiaGoi",
                        principalColumn: "MaGiaGoi");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoiTap_MaGoiTap",
                table: "GoiTap",
                column: "MaGoiTap");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "NhanVien",
                column: "MaChucVu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoiTap");

            migrationBuilder.DropTable(
                name: "HoiVien");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ThietBi");

            migrationBuilder.DropTable(
                name: "GiaGoi");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
