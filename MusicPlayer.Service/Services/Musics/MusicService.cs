
using AutoMapper;
using MusicPlayer.Data.IRepositories;
using MusicPlayer.Domain.Entities.Commons;
using MusicPlayer.Domain.Entities.Musics;
using MusicPlayer.Service.DTO.Musics;
using MusicPlayer.Service.Interfaces.Commons;
using MusicPlayer.Service.Interfaces.Musics;
using System.Linq.Expressions;

namespace MusicPlayer.Service.Services.Musics
{
    public class MusicService : IMusicService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAttachmentService attachmentService;
        private readonly IMapper mapper;

        public MusicService(
            IUnitOfWork unitOfWork,
            IAttachmentService attachmentService,
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.attachmentService = attachmentService;
            this.mapper = mapper;
        }

        public async Task<Music> CreateAsync(MusicForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<Music, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Music>> GetAllAsync(Expression<Func<Music, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<Music?> GetAsync(Expression<Func<Music, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Music> UpdateAsync(Expression<Func<Music, bool>> expression, MusicForCreationDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
