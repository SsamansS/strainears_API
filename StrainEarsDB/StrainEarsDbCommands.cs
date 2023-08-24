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
        public static List<Playlist> GetPlaylistsByUserId(int userId)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                return context.Playlists
                    .Where(u => u.Id == userId) as List<Playlist>;
            }
        }
        public static void RegistrationUser(User user)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        public static void RegistrationArtist(Artist artist)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.Artists.Add(artist);
                context.SaveChanges();
            }
        }
        public static void AddAlbum(Album album)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.Albums.Add(album);
                context.SaveChanges();
            }
        }
        public static void AddTrack(Track track)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.Tracks.Add(track);
                context.SaveChanges();
            }
        }
        public static void CreatePlaylist(Playlist playlist)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.Playlists.Add(playlist);
                context.SaveChanges();
            }
        }
        public static void AddTrackToPlaylist(PlaylistTrack playlisttrack)
        {
            using (StrainEarsContext context = new StrainEarsContext())
            {
                context.PlaylistTracks.Add(playlisttrack);
                context.SaveChanges();
            }
        }
    }
}
