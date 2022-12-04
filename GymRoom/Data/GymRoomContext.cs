using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GymRoom.Models;
namespace GymRoom.Data
 {
    public class GymRoomContext : DbContext
    {
        public GymRoomContext (DbContextOptions<GymRoomContext> options)
            : base(options)
        {
        }

        public DbSet<GymRoom.Models.HoiVien> HoiVien { get; set; }

        public DbSet<GymRoom.Models.NhanVien> NhanVien { get; set; }

        public DbSet<GymRoom.Models.ThietBi> ThietBi { get; set; }

        public DbSet<GymRoom.Models.ThanhToan> ThanhToan { get; set; }

        public DbSet<GymRoom.Models.ChucVu> ChucVu { get; set; }

        public DbSet<GymRoom.Models.GoiTap> GoiTap { get; set; }

        public DbSet<GymRoom.Models.TinhTrang> TinhTrang { get; set; }
    }
 }
