using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class NobetEntity
    {
        public int NobetId { get; set; }
        public int BolumId { get; set; }
        public int AsistanId { get; set; }
        public DateTime NobetBit { get; set; }
        public DateTime NobetBas { get; set; }
    }
}
