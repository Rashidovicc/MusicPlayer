using MusicPlayer.Domain.Entities.Musics;
using MusicPlayer.Service.DTO.Musics;
using System.Linq.Expressions;

namespace MusicPlayer.Service.Interfaces.Musics
{
    public interface IMusicService
    {
        Task<Music> CreateAsync(MusicForCreationDto dto);
        Task<Music?> GetAsync(Expression<Func<Music, bool>> expression);
        Task<IEnumerable<Music>> GetAllAsync(Expression<Func<Music, bool>>? expression = null);
        Task<Music> UpdateAsync(Expression<Func<Music, bool>> expression, MusicForCreationDto dto);
        Task<bool> DeleteAsync(Expression<Func<Music, bool>> expression);
    }
}
