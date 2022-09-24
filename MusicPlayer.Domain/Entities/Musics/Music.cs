using MusicPlayer.Domain.Commons;
using MusicPlayer.Domain.Entities.Commons;
using MusicPlayer.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Domain.Entities.Musics
{
    public class Music : Auditable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; }
        
        public long UserId { get; set; }
        public User User { get; set; }

        public long ImageId { get; set; }
        public Attachment image { get; set; }
    }
}
