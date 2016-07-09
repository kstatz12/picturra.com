using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class Portfolio
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        [Required]
        public string Statement { get; set; }
        [Reference]
        public List<Series> Series { get; set; } 
    }
}
