
using MusicPlayer.Domain.Entities.Commons;

namespace MusicPlayer.Service.Interfaces.Commons
{
    public interface IAttachmentService
    {
        Task<Attachment> UploadAsync(Stream stream, string fileName);
        Task<Attachment> UpdateAsync(long id, Stream stream);
        Task<bool> DeleteAsync(long id);
    }
}
