using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class RandevuEntity
    {
        public int RandevuId { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public int AsistanId { get; set; }
        public string OgretimId { get; set; }

    }
}
