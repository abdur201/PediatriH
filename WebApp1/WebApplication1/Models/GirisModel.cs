using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class GirisModel
    {
        [Key]
        public int LoginId { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; } //1 admin 2 kullanıcı 3 ziyaretçi
    }
}
