using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrainEarsDB.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; }
        public string Password { get; set; } = null!;
        public DateTime CreatedDate { get; set; }

        public ICollection<Playlist> Playlists { get; set; } = null!;
    }
}
