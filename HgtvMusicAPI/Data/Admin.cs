using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HgtvMusicAPI.Data
{
    [Table("Admins")]
    public class Admin
    {
        [Key]
        public int IdAdmin { get; set; }
        public int? IdUser { get; set; }
        [ForeignKey("IdUser")]
        public User User { get; set; }
    }
}
