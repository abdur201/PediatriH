using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class BolumModel
    {
        [Key]

        public int BolumId { get; set; }
        public string BolumName { get; set; }
        public int HastaSayisi { get; set; }
        public int BosYatakSayisi { get; set; }
        public string Info { get; set; } 
        public int OgretimId { get; set; }  
        
        


    }
}
