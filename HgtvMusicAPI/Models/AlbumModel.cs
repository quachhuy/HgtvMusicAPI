﻿using System.ComponentModel.DataAnnotations;

namespace HgtvMusicAPI.Models
{
    public class AlbumModel
    {

        [Required]
        [MaxLength(50)]
        public string? NameAlbum { get; set; }
        public DateOnly ReleaseYear { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        public string? Path_Img { get; set; }

    }
}
