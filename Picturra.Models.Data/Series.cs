using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class Series
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        public string Title { get; set; }
        [Reference]
        public Image Image { get; set; }
        [Reference]
        public List<Project> Projects { get; set; } 
    }
}
