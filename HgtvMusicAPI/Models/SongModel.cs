using System.ComponentModel.DataAnnotations;

namespace HgtvMusicAPI.Models
{
    public class SongModel
    {
        [MaxLength(50)]
        [Required]
        public string NameSong { get; set; }

        public string? Path_Img { get; set; }
    }
}
