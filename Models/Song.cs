using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PlaylistManager.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Author { get; set; }
        
        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

        public ICollection <PlaylistSong> PlaylistSongs { get; set; }
    }
}
