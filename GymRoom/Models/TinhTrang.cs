using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymRoom.Models
{
    public class TinhTrang
    {
        [Key]

        [Display( Name = "Mã tình trạng")]
        public string? MaTinhTrang{get; set;}

        [Display( Name = "Tên nội dung")]
        public string? TenND{get; set;}
       
        [Display( Name = "Tình trạng thiết bị")]
        public string? TinhTrangND { get; set; }
         
    }
}