using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xeptions;

namespace MusicPlayer.Service.Exceptions
{
    public class NotFoundException : Xeption
    {
        public NotFoundException(long id)
            : base(message: $"Couldn't find with id: {id}.")
        {}
    }
}
