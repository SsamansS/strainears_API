using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrainEarsDB.Models
{
    public class PlaylistTrack
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public int PlaylistId { get; set; }

        public Track Track { get; set; } = null!;
        public Playlist Playlist { get; set; } = null!;
    }
}
