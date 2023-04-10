using Microsoft.EntityFrameworkCore;
using StrainEarsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrainEarsDB.Data
{
    public class StrainEarsContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Playlist> Playlists { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AMANURLANUULU;Database=StrainEarsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }
    }
}
