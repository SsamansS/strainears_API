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
            using (StrainEarsContext context = new StrainEarsContext())
            {
                List<Playlist> playlists = context.Playlists
                    .ToList();

                Console.WriteLine(playlists.Count);
                foreach(var item in playlists)
                {
                    if (item.UserId == 1)
                    {
                        Console.WriteLine(item.PlaylistName);
                    }
                    
                }
            }
            //StrainEarsDbCommands.AddTrack(new Track() { 
            //    TrackName = "TrackOFArtist1",
            //    ArtistId = 1
            //});

            //StrainEarsDbCommands.AddAlbum(new Album() { 
            //    AlbumName = "Album of artist1",
            //    ArtistId = 1,
            //    ReleaseDate = DateTime.Now,
            //    Category = "Punk"
            //});
            //StrainEarsDbCommands.AddAlbum(new Album()
            //{
            //    AlbumName = "Album of artist2",
            //    ArtistId = 2,
            //    ReleaseDate = DateTime.Now,
            //    Category = "Rap"
            //});
            //StrainEarsDbCommands.AddAlbum(new Album()
            //{
            //    AlbumName = "Album of artist3",
            //    ArtistId = 3,
            //    ReleaseDate = DateTime.Now,
            //    Category = "Folk"
            //});
            //StrainEarsDbCommands.AddAlbum(new Album()
            //{
            //    AlbumName = "Album3 of artist3",
            //    ArtistId = 3,
            //    ReleaseDate = DateTime.Now,
            //    Category = "Classic"
            //});
            Console.WriteLine("Hello World!");
        }
    }
}
