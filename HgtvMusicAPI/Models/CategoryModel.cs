﻿using System.ComponentModel.DataAnnotations;

namespace HgtvMusicAPI.Models
{
    public class CategoryModel
    {
        [Required]
        public string? NameCategory { get; set; }
        public string? Path_Img { get; set; }

    }
}
