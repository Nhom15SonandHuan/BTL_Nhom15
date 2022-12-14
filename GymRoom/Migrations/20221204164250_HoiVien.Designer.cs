// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using GymRoom.Data;

#nullable disable

namespace GymRoom.Migrations
{
    [DbContext(typeof(GymRoomContext))]
    [Migration("20221204164250_HoiVien")]
    partial class HoiVien
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("GymRoom.Models.ChucVu", b =>
                {
                    b.Property<string>("MaChucVu")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenChucVu")
                        .HasColumnType("TEXT");

                    b.HasKey("MaChucVu");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("GymRoom.Models.GoiTap", b =>
                {
                    b.Property<string>("MaGoiTap")
                        .HasColumnType("TEXT");

                    b.Property<string>("GiaGoi")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenGoi")
                        .HasColumnType("TEXT");

                    b.HasKey("MaGoiTap");

                    b.ToTable("GoiTap");
                });

            modelBuilder.Entity("GymRoom.Models.HoiVien", b =>
                {
                    b.Property<string>("HoiVienID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailHV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaGoiTap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Ngaybatdau")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Ngayketthuc")
                        .HasColumnType("TEXT");

                    b.Property<string>("SĐT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenHV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HoiVienID");

                    b.HasIndex("MaGoiTap");

                    b.ToTable("HoiVien");
                });

            modelBuilder.Entity("GymRoom.Models.NhanVien", b =>
                {
                    b.Property<string>("MaID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailNV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaChucVu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SĐT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaID");

                    b.HasIndex("MaChucVu");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("GymRoom.Models.ThanhToan", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("TEXT");

                    b.Property<string>("HoiVienID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaGoiTap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaTinhTrang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Ngayban")
                        .HasColumnType("TEXT");

                    b.HasKey("MaHD");

                    b.HasIndex("HoiVienID");

                    b.HasIndex("MaGoiTap");

                    b.HasIndex("MaTinhTrang");

                    b.ToTable("ThanhToan");
                });

            modelBuilder.Entity("GymRoom.Models.ThietBi", b =>
                {
                    b.Property<string>("MaTB")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaTinhTrang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Soluong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenTB")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("size")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaTB");

                    b.HasIndex("MaTinhTrang");

                    b.ToTable("ThietBi");
                });

            modelBuilder.Entity("GymRoom.Models.TinhTrang", b =>
                {
                    b.Property<string>("MaTinhTrang")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenND")
                        .HasColumnType("TEXT");

                    b.Property<string>("TinhTrangND")
                        .HasColumnType("TEXT");

                    b.HasKey("MaTinhTrang");

                    b.ToTable("TinhTrang");
                });

            modelBuilder.Entity("GymRoom.Models.HoiVien", b =>
                {
                    b.HasOne("GymRoom.Models.GoiTap", "GoiTap")
                        .WithMany()
                        .HasForeignKey("MaGoiTap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoiTap");
                });

            modelBuilder.Entity("GymRoom.Models.NhanVien", b =>
                {
                    b.HasOne("GymRoom.Models.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("MaChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("GymRoom.Models.ThanhToan", b =>
                {
                    b.HasOne("GymRoom.Models.HoiVien", "HoiVien")
                        .WithMany()
                        .HasForeignKey("HoiVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymRoom.Models.GoiTap", "GoiTap")
                        .WithMany()
                        .HasForeignKey("MaGoiTap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymRoom.Models.TinhTrang", "TinhTrang")
                        .WithMany()
                        .HasForeignKey("MaTinhTrang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoiTap");

                    b.Navigation("HoiVien");

                    b.Navigation("TinhTrang");
                });

            modelBuilder.Entity("GymRoom.Models.ThietBi", b =>
                {
                    b.HasOne("GymRoom.Models.TinhTrang", "TinhTrang")
                        .WithMany()
                        .HasForeignKey("MaTinhTrang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TinhTrang");
                });
#pragma warning restore 612, 618
        }
    }
}
