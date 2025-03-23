using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class AcilEntity
    {

        public int AcilId { get; set; }
        public DateTime DateTime { get; set; }
        public int BolumId { get; set; }

        public string Info { get; set; }

    }
}
