namespace StrainEarsDB.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string TrackName { get; set; } = null!;
        public int? ArtistId { get; set; }
        public int? AlbumId { get; set; }

        public Artist Artist { get; set; } = null!;
        public Album Album { get; set; } = null!;
    }
}