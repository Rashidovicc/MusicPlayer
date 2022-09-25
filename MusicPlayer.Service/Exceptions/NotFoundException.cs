
using Xeptions;

namespace MusicPlayer.Service.Exceptions
{
    public class NotFoundException : Xeption
    {
        public NotFoundException(string model)
            : base(message: $"Couldn't find {model}.")
        {}
    }
}
