using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcGym.Models;

namespace MvcGym.Data
{
    public class MvcGymContext : DbContext
    {
        public MvcGymContext (DbContextOptions<MvcGymContext> options)
            : base(options)
        {
        }
        public DbSet<MvcGym.Models.NhanVien> NhanVien { get; set; }
        public DbSet<MvcGym.Models.HoiVien> HoiVien { get; set; }
        public DbSet<MvcGym.Models.ChucVu> ChucVu { get; set; }
        public DbSet<MvcGym.Models.ThietBi> ThietBi { get; set; }
        public DbSet<MvcGym.Models.GoiTap> GoiTap { get; set; }
        public DbSet<MvcGym.Models.GiaGoi> GiaGoi { get; set; }
    }
}
