using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class AcilModel
    {
        [Key]

        public int AcilId { get; set; }
        public DateTime DateTime { get; set; }
        public int BolumId { get; set; }
        
        public string Info { get; set; }
    }
}
