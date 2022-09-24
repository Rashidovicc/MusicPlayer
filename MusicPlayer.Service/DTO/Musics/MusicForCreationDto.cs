using Microsoft.AspNetCore.Http;

namespace MusicPlayer.Service.DTO.Musics
{
    public class MusicForCreationDto
    {
        public IFormFile File { get; set; }
    }
}
