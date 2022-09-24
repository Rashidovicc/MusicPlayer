using Xeptions;

namespace MusicPlayer.Service.Exceptions
{
    public class InvalidInputException : Xeption
    {
        public InvalidInputException(string model,Exception innerException)
           : base(message: $"{model} is invalid input, please contact support.", innerException)
        { }
    }
}
