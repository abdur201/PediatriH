using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class IndexModel
    {
        [Key]
        public int ScriptId { get; set; }
        public DateTime Date { get; set; }
        public string Script { get; set; }
    }
}
