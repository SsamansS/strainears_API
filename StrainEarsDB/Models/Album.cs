using System;
using System.Collections.Generic;

namespace StrainEarsDB.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumName { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; } = null!;
        public int ArtistId { get; set; }

        public Artist Artist { get; set; } = null!;
        public ICollection<Track> Tracks { get; set; } = null!;
    }
}