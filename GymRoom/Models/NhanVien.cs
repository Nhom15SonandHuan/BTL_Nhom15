using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymRoom.Models
{
    public class NhanVien
    {
        [Key]
        [Required]
        [Display( Name = "Mã NV")]
        public string? MaID{get; set;}
        [Required]
        [Display( Name = "Tên NV")]
        public string? TenNV{get; set;}

         [Required]
         [Display( Name = "Địa chỉ")]
        public string? Address{get; set;}

        [Required]
        [MinLength(10)]
        [Display( Name = "Số điện thoại")]
        public string? SĐT{get; set;}
        
        [Required]
        [StringLength(12)]
        [Display( Name = "Email NV")]
        public string? EmailNV{get; set;}

        [Required]
        [Display( Name = "Chức vụ")]
        public string? MaChucVu{get; set;}
         [ForeignKey("MaChucVu")]
       public ChucVu? ChucVu{get; set;}
          
    }
}