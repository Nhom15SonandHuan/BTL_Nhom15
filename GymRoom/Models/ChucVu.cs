using System.ComponentModel.DataAnnotations;
namespace GymRoom.Models
{
    public class ChucVu
    {
        [Key]

        [Display( Name = "Mã chức vụ")]
        public string? MaChucVu{get; set;}

        [Display( Name = "Tên chức vụ")]
        public string? TenChucVu{get; set;}
    }
}