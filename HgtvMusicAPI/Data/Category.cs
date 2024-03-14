using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HgtvMusicAPI.Data
{
    [Table("Category")]
    public class Category
    {
        [Key] 
        public int IdCategory { get; set; }
        [Required]
        public string? NameCategory { get; set; }
        public string? Path_Img { get; set; }
        
        public virtual ICollection<Song>?Songs { get; set;}

    }
}
