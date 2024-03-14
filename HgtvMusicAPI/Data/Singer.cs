using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HgtvMusicAPI.Data
{
    [Table("Singer")]
    public class Singer
    {
        [Key]
        public int IdSinger { get; set; }
        [StringLength(100)]
        [Required]
        public string NameSinger { get; set; }
        public int Follower { get; set; }
        public string Path_Img { get; set; }

        public virtual ICollection<Album> Albums { get; set; } 

        public virtual ICollection<Song> Songs { get; set; }

    }
}
