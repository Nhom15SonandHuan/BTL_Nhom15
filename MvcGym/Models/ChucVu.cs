using System.ComponentModel.DataAnnotations;
namespace MvcGym.Models
{
    public class ChucVu
    {
        [Key]
        public string? MaChucVu{get; set;}
        public string? TenChucVu{get; set;}
    }
}