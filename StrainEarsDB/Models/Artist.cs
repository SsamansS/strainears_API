using System.Collections.Generic;

namespace StrainEarsDB.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string ArtistName { get; set; } = null!;
        public string Country { get; set; } = null!;

        public ICollection<Track> Tracks { get; set; } = null!;
        public ICollection<Album> Albums { get; set; } = null!;
    }
}