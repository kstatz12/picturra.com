using System.Collections.Generic;

namespace Picturra.Models.Profile
{
    public class Series : IModelBase<int>
    {
        public Series()
        {
            TitleImage = new Image.Image();
            Projects = new List<Project>();
        }
        public int Id { get; set;}
        public string Title { get; set; }
        public string Description { get; set; }
        public Image.Image TitleImage { get; set; }
        public List<Project> Projects { get; set; } 
    }
}
