using System.Threading.Tasks.Dataflow;
using System.ComponentModel.DataAnnotations;
namespace GymRoom.Models
{
    public class GiaGoi
    {
        [Key]

        [Display( Name = "Mã Giá Gói")]
        public string? MaGiaGoi{get; set;}

        [Display( Name = "Tên Gói")]
        public string? TenGoi{get; set;}

        [Display( Name = "Giá Gói Tập")]
        public string? GiaGoiTap { get; set; }    
    }
}