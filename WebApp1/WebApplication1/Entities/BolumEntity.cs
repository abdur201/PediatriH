using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class BolumEntity
    {
        public int BolumId { get; set; }
        public string BolumName { get; set; }
        public int HastaSayisi { get; set; }
        public int BosYatakSayisi { get; set; }
        public string Info { get; set; }
        public int OgretimId { get; set; }



    }
}
