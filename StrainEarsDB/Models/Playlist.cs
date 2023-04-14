using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrainEarsDB.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string PlaylistName { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Category { get; set; } = null!;

        public User User { get; set; } = null!;
        public ICollection<PlaylistTrack> PlaylistTracks { get; set; } = null!;
    }
}
