using System.Collections.Generic;
namespace Picturra.Models.Profile
{
    public class Project : IModelBase<int>
    {
        public Project()
        {
            TitleImage = new Image.Image();
            Images = new List<Image.Image>();
        }
        public int Id { get; set; }
        public Image.Image TitleImage { get; set; }
        public string Title { get; set; }
        public Enums.Enums.Medium Medium { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Year { get; set; }
        public int LikeCount { get; set; }
        public List<Image.Image> Images { get; set; }
    }
}