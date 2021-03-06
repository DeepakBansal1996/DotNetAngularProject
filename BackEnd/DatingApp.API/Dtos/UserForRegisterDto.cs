using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    { 
        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }
        
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "You must specify password between 8 and 30")]
        public string Password { get; set; }
    }
}