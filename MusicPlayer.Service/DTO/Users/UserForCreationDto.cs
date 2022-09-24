using System.ComponentModel.DataAnnotations;

namespace MusicPlayer.Service.DTO.Users
{
    public class UserForCreationDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
