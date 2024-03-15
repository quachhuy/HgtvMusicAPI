using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HgtvMusicAPI.Data
{
    [Table("Album")]
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        [Required]
        public string? NameAlbum { get; set; }
        public DateOnly ReleaseYear { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        public string? Path_Img { get; set; }
        public int? IdSinger { get; set; }
        [ForeignKey("IdSinger")]
        public Singer Singer { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

    }
}
