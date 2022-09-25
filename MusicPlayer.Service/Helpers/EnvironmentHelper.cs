
namespace MusicPlayer.Service.Helpers
{
    public abstract class EnvironmentHelper
    {
        public static string WebRootPath { get; set; }
        public static string AttachmentPath => Path.Combine(WebRootPath, FilePath); // = wwwroot/files
        public static string FilePath => "files";
    }
}
