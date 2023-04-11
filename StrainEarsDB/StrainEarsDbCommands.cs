using StrainEarsDB.Data;
using StrainEarsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StrainEarsDB
{
    public static class StrainEarsDbCommands
    {
        public static void RegistrationUser(User user)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.Users.Add(user);
            }
        }
        public static void RegistrationArtist(Artist artist)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.Artists.Add(artist);
            }
        }
        public static void AddAlbum(Album album)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.Albums.Add(album);
            }
        }
    }
}
