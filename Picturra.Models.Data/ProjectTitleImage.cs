using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class ProjectTitleImage : DataImage
    {
        [ForeignKey(typeof(Project))]
        public int ProjectId { get; set; }
    }
}