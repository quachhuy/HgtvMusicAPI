using System.ComponentModel.DataAnnotations;

namespace HgtvMusicAPI.Models
{
    public class AlbumVM
    {
        public int IdAlbum { get; set; }
        public string? NameAlbum { get; set; }
        public DateOnly ReleaseYear { get; set; }
        public int Quantity { get; set; }
        public string? Path_Img { get; set; }
    }
}
