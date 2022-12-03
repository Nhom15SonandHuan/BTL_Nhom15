using System.ComponentModel.DataAnnotations;
namespace MvcGym.Models
{
    public class GiaGoi
    {
        [Key]
        public string? MaGiaGoi{get; set;}
        public string? TenGoi{get; set;}
    }
}