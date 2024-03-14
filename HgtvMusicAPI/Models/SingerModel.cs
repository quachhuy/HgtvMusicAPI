using System.ComponentModel.DataAnnotations;

namespace HgtvMusicAPI.Models
{
    public class SingerModel
    {
            [StringLength(100)]
            [Required]
            public string NameSinger { get; set; }
            public int Follower { get; set; }
            public string Path_Img { get; set; }

}
}
