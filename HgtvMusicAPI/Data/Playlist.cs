using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HgtvMusicAPI.Data
{
    [Table("Playlist")]
    public class Playlist
    {
        [Key]
        public int IdPlaylist { get; set; }
        [MaxLength(50)]
        [Required]
        public string PlaylistName { get; set;}
        public DateOnly CreatedDate { get; set; }
        public int? IdUser {  get; set; }
        [ForeignKey("IdUser")]
        public User User { get; set; }
    }
}
