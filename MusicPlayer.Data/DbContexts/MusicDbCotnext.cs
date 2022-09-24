
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Domain.Entities.Commons;
using MusicPlayer.Domain.Entities.Musics;
using MusicPlayer.Domain.Entities.Users;

namespace MusicPlayer.Data.DbContexts
{
    public class MusicDbCotnext : DbContext
    {
        public MusicDbCotnext(DbContextOptions<MusicDbCotnext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Music> Musics { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
    }
}
