using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Authentication.ExtendedProtection;

namespace learn.Models
{
    public class Category 
    {
        
        [Key] public int id { get; set; }
        [Required] public String Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime createdDateTime { get; set; } = DateTime.Now;
    }
}
