using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class Project
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        [Reference]
        public Image TitleImage { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Medium { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public string Year { get; set; }
        public int LikeCount { get; set; }
        [Reference]
        public List<Image> Images { get; set; } 
    }
}
