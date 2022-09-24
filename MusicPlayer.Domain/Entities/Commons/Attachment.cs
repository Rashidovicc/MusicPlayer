
using MusicPlayer.Domain.Commons;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer.Domain.Entities.Commons
{
    public class Attachment : Auditable
    {
#pragma warning disable CS8618
        [Required]
        public string Path { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
