
using MusicPlayer.Data.IRepositories;
using MusicPlayer.Domain.Entities.Commons;
using MusicPlayer.Service.Helpers;
using MusicPlayer.Service.Interfaces.Commons;

namespace MusicPlayer.Service.Services.Commons
{
    public class AttachmentService : IAttachmentService
    {
        private readonly IUnitOfWork unitOfWork;
        public AttachmentService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Attachment> UpdateAsync(long id, Stream stream)
        {
            throw new NotImplementedException();
        }

        public async Task<Attachment> UploadAsync(Stream stream, string fileName)
        {
            // store to wwwroot

            fileName = Path.Combine(Guid.NewGuid().ToString("N")) + '-' + fileName; // = 6nf7f94bh84h37hbf84-nature.png
            string filePath = Path.Combine(EnvironmentHelper.AttachmentPath, fileName); // = wwwroot/files/6nf7f94bh84h37hbf84-nature.png

            FileStream fileStream = File.Create(filePath);
            await stream.CopyToAsync(fileStream);

            await fileStream.FlushAsync();
            fileStream.Close();

            // store to database

            Attachment attachment = await this.unitOfWork.Attachments.CreateAsync(new Attachment
            {
                Name = fileName,
                Path = Path.Combine(EnvironmentHelper.FilePath, fileName),
                CreatedAt = DateTime.UtcNow,
            });

            await this.unitOfWork.SaveAsync();

            return attachment;
        }
    }
}
