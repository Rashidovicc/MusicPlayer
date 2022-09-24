using MusicPlayer.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Domain.Entities.Commons
{
    public class Attachment : Auditable
    {
        [Required]
        public string Path { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
