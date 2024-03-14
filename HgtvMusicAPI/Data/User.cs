using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HgtvMusicAPI.Data
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set;}
        public virtual ICollection<Admin> Admins { get; set; }
    }
}
