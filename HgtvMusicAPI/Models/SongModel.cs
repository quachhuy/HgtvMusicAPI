using System.ComponentModel.DataAnnotations;

namespace HgtvMusicAPI.Models
{
    public class SongModel
    {
        public string NameSong { get; set; }

        public string? Path_Img { get; set; }
    }
}
