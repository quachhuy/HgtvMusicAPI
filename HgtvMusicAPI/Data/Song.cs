using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HgtvMusicAPI.Data
{
    [Table("Song")]
    public class Song
    {
        [Key]
        public int IdSong { get; set; }
        [MaxLength(50)]
        [Required]
        public string NameSong { get; set; }

        public string? Path_Img { get; set; }
        public int? IdCategory { get; set; }
        [ForeignKey("IdCategory")]
        public Category Category { get; set; }

        public int? IdSinger { get; set; }
        [ForeignKey("IdSinger")]
        public Singer Singer { get; set; }

        public int? IdAlbum { get; set; }
        [ForeignKey("IdAlbum")]
        public Album Album { get; set; }



    }
}
