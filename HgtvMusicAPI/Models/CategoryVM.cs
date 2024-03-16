using System.ComponentModel.DataAnnotations;

namespace HgtvMusicAPI.Models
{
    public class CategoryVM
    {
        public int IdCategory { get; set; }
        public string? NameCategory { get; set; }
        public string? Path_Img { get; set; }

    }
}
