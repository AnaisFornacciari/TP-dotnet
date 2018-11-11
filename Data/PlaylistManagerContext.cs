using Microsoft.EntityFrameworkCore;
using PlaylistManager.Models;

namespace PlaylistManager.Data
{    public class PlaylistManagerContext : DbContext
    {
        public PlaylistManagerContext(DbContextOptions<PlaylistManagerContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./Data/PlaylistManager.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistSong>()
                .HasKey(p => new { p.SongId, p.PlaylistId })
            ;

            modelBuilder.Entity<PlaylistSong>()
                .HasOne(sp => sp.Song)
                .WithMany(s => s.PlaylistSongs)
                .HasForeignKey(sp => sp.SongId)
            ;

            modelBuilder.Entity<PlaylistSong>()
                .HasOne(sp => sp.Playlist)
                .WithMany(p => p.PlaylistSongs)
                .HasForeignKey(sp => sp.PlaylistId)
            ;
        }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<PlaylistSong> SongOfPlaylist { get; set; }
    }
}