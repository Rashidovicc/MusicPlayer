
using AutoMapper;
using MusicPlayer.Domain.Entities.Musics;
using MusicPlayer.Domain.Entities.Users;
using MusicPlayer.Service.DTO.Musics;
using MusicPlayer.Service.DTO.Users;

namespace MusicPlayer.Service.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserForCreationDto, User>().ReverseMap();
            CreateMap<MusicForCreationDto, Music>().ReverseMap();
        }
    }
}
