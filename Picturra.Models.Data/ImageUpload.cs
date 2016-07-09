using System;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class ImageUpload
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        [Required]
        public string Ip { get; set; }
        [Required]
        public Guid LoginId { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}