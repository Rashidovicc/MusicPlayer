
using MusicPlayer.Domain.Enums;

namespace MusicPlayer.Domain.Commons
{
    public class Auditable
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public ItemState ItemState { get; set; } = ItemState.Created;
    }
}
