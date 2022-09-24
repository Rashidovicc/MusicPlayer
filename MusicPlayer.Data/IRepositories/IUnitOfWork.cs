
using MusicPlayer.Domain.Entities.Commons;
using MusicPlayer.Domain.Entities.Musics;
using MusicPlayer.Domain.Entities.Users;

namespace MusicPlayer.Data.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {

        IGenericRepository<User> Users { get; }
        IGenericRepository<Music> Musics { get; }
        IGenericRepository<Attachment> Attachments { get; }

        Task SaveAsync();
    }
}
