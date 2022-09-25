using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Data.IRepositories;
using MusicPlayer.Domain.Entities.Commons;
using MusicPlayer.Domain.Entities.Users;
using MusicPlayer.Service.DTO.Users;
using MusicPlayer.Service.Exceptions;
using MusicPlayer.Service.Interfaces.Commons;
using MusicPlayer.Service.Interfaces.Users;
using System.Linq.Expressions;

namespace MusicPlayer.Service.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAttachmentService attachmentService;
        private readonly IMapper mapper;
        public UserService(
            IUnitOfWork unitOfWork,
            IAttachmentService attachmentService, 
            IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.attachmentService = attachmentService;
            this.mapper = mapper;
        }

        public async Task<User> CreateAsync(UserForCreationDto dto)
        {
            User? existUser = await this.unitOfWork.Users.GetAsync(x =>
                        x.Email.Equals(dto.Email) &&
                        x.Password.Equals(dto.Password));

            if (existUser is null)
                throw new AlreadyExistsException(nameof(User), new Exception());

            Attachment attachment = await this.attachmentService.UploadAsync(dto.File.OpenReadStream(), dto.File.Name);

            User mappedUser = this.mapper.Map<User>(dto);
            User user = await this.unitOfWork.Users.CreateAsync(mappedUser);

            user.AttachmentId = attachment.Id;

            await this.unitOfWork.SaveAsync();

            return user;
        }

        public async Task<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            User? user = await this.unitOfWork.Users.GetAsync(expression);

            if (user is null)
                throw new NotFoundException(nameof(User));

            this.unitOfWork.Users.Delete(user);

            return true;
        }

        public async Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>>? expression = null)
            => await this.unitOfWork.Users.GetAll(expression).ToListAsync();

        public async Task<User?> GetAsync(Expression<Func<User, bool>> expression)
        {
            User? user =  await this.unitOfWork.Users.GetAsync(expression);

            if (user is null)
                throw new NotFoundException(nameof(User));

            return user;
        }

        public async Task<User> UpdateAsync(Expression<Func<User, bool>> expression, UserForCreationDto dto)
        {
            User? user = await this.unitOfWork.Users.GetAsync(expression);

            if (user is null)
                throw new NotFoundException(nameof(User));

            user = this.mapper.Map(dto, user);
            user.UpdatedAt = DateTime.UtcNow;

            User entity = this.unitOfWork.Users.Update(user);

            await this.unitOfWork.SaveAsync();

            return entity;
        }
    }
}
