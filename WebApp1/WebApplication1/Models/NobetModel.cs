using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web.Models
{
    public class NobetModel
    {
        [Key]

        public int NobetId { get; set; }
        public int BolumId {  get; set; }
        public int AsistanId { get; set;}
        public DateTime NobetBit { get; set;}
        public DateTime NobetBas { get; set; }

        
       
    }
}
