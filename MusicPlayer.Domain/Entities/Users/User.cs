
using MusicPlayer.Domain.Commons;
using MusicPlayer.Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer.Domain.Entities.Users
{
    public class User : Auditable
    {
#pragma warning disable CS8618
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public long AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
    }
}
