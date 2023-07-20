using marsev.Enums;
using System.ComponentModel.DataAnnotations;

namespace marsev.Models
{
    public class AppUser : BaseEntity
    {
        [MaxLength(15)]
        public string UserName { get; set;}

//        [Required(ErrorMessage ="Zorunlu Alan")]
        public string Password { get; set;}
        public Role Role { get; set;}
    }
}
