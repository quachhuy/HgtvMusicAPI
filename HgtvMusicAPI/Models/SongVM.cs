using System.ComponentModel.DataAnnotations;

namespace HgtvMusicAPI.Models
{
    public class SongVM
    {
        public int IdSong { get; set; }
        public string NameSong { get; set; }
        public string? Path_Img { get; set; }
    }
}
