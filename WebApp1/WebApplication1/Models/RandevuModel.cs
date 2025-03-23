using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class RandevuModel
    {
        [Key]

        public int RandevuId { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public int AsistanId { get; set; }
        public string OgretimId { get; set; }
     
    }
}
