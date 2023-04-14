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
            StrainEarsDbCommands.RegistrationArtist(new Artist()
            {
                ArtistName = "Artist1",
                Country = "Kyrgyzstan"
            });
            StrainEarsDbCommands.RegistrationArtist(new Artist()
            {
                ArtistName = "Artist2",
                Country = "China"
            });
            StrainEarsDbCommands.RegistrationArtist(new Artist()
            {
                ArtistName = "Artist3",
                Country = "Garman"
            });
            StrainEarsDbCommands.RegistrationArtist(new Artist()
            {
                ArtistName = "Artist4",
                Country = "Israel"
            });
            Console.WriteLine("Hello World!");
        }
    }
}
