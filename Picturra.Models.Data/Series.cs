using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class Series
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Reference]
        public SeriesTitleImage TitleImage { get; set; }
        [Reference]
        public List<Project> Projects { get; set; } 
    }
}
