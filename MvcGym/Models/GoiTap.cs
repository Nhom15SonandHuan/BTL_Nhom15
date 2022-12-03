using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcGym.Models
{
    public class GoiTap
    {
        [Key]
        public string? GoiID{get; set;}
        public string? MaGoiTap{get; set;}
        [ForeignKey("MaGoiTap")]
        public GiaGoi? GiaGoi{get; set;}
    }
}