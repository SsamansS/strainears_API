using StrainEarsDB.Data;
using StrainEarsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StrainEarsDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //using(StrainEarsContext context = new StrainEarsContext())
            //{
            //    List<Track> tracks = new List<Track>()
            //    {
            //        new Track()
            //        {
            //            TrackName = "Track"
            //        }
            //    };
            //}
            StrainEarsDbCommands.AddTrack(new Track() { 
                TrackName = "TrackOFArtist1",
                ArtistId = 1
            });

            StrainEarsDbCommands.AddAlbum(new Album() { 
                AlbumName = "Album of artist1",
                ArtistId = 1,
                ReleaseDate = DateTime.Now,
                Category = "Punk"
            });
            StrainEarsDbCommands.AddAlbum(new Album()
            {
                AlbumName = "Album of artist2",
                ArtistId = 2,
                ReleaseDate = DateTime.Now,
                Category = "Rap"
            });
            StrainEarsDbCommands.AddAlbum(new Album()
            {
                AlbumName = "Album of artist3",
                ArtistId = 3,
                ReleaseDate = DateTime.Now,
                Category = "Folk"
            });
            StrainEarsDbCommands.AddAlbum(new Album()
            {
                AlbumName = "Album2 of artist3",
                ArtistId = 3,
                ReleaseDate = DateTime.Now,
                Category = "Classic"
            });
            Console.WriteLine("Hello World!");
        }
    }
}
