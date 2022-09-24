
using MusicPlayer.Data.DbContexts;
using MusicPlayer.Data.IRepositories;
using MusicPlayer.Domain.Entities.Commons;
using MusicPlayer.Domain.Entities.Musics;
using MusicPlayer.Domain.Entities.Users;

namespace MusicPlayer.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MusicDbCotnext dbCotnext;
        public UnitOfWork(MusicDbCotnext dbCotnext)
        {
            this.dbCotnext = dbCotnext;

            this.Users = new GenericReposirtory<User>(dbCotnext);
            this.Musics = new GenericReposirtory<Music>(dbCotnext);
            this.Attachments = new GenericReposirtory<Attachment>(dbCotnext);
        }
        public IGenericRepository<User> Users { get; }

        public IGenericRepository<Music> Musics { get; }

        public IGenericRepository<Attachment> Attachments { get; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
            => await this.dbCotnext.SaveChangesAsync();
    }
}
