
using MusicPlayer.Domain.Entities.Users;
using MusicPlayer.Service.DTO.Users;
using System.Linq.Expressions;

namespace MusicPlayer.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<User> CreateAsync(UserForCreationDto dto);
        Task<User?> GetAsync(Expression<Func<User, bool>> expression);
        Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>>? expression = null);
        Task<User> UpdateAsync(Expression<Func<User, bool>> expression, UserForCreationDto dto);
        Task<bool> DeleteAsync(Expression<Func<User, bool>> expression);
    }
}
