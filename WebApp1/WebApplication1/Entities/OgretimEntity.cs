using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class OgretimEntity
    {
        public int OgretimId { get; set; }
        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Info { get; set; }


    }
}
