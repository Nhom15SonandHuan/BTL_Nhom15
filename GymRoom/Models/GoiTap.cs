using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymRoom.Models
{
    public class GoiTap
    {
        [Key]

        [Display( Name = "Gói ID")]
        public string? GoiID{get; set;}

        [Display( Name = "Mã Gói Tập")]
        public string? MaGiaGoi{get; set;}
        [ForeignKey("MaGiaGoi")]
        public GiaGoi? GiaGoi{get; set;}
    }
}