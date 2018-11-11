using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlaylistManager.Models
{
    public class Playlist
    {
        public int PlaylistId { get; set; }

        [Required]
        public string Name { get; set; }
        public bool IsPrivate { get; set; } = true ;

        [Required]
        public string UserName { get; set; }

        public List <Song> Songs { get; set; }

        public ICollection <PlaylistSong> PlaylistSongs { get; set; }
    }
}