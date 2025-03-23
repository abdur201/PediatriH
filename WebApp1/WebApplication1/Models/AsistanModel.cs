using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class AsistanModel
    {
        [Key]

        public int AsistanId { get; set; }
        public string FullName { get; set; }
     
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Info { get; set; }
   
      

    }
}
