using System;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class Image
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
        public string Caption { get; set; }
        [Required]
        public string PublicKey { get; set; }
        [Required]
        public Guid CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}