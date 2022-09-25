
using Xeptions;

namespace MusicPlayer.Service.Exceptions
{
    public class AlreadyExistsException : Xeption
    {
        public AlreadyExistsException(string model,Exception exception)
            : base(message: $"{model} already exists.", exception)
        {}
    }
}
