using System;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class Profile
    {
        [AutoIncrement]
        [PrimaryKey]
        public int Id { get; set; }
        [Required]
        public Guid LoginId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string About { get; set; }
        [Reference]
        public ProfileImage Image { get; set; }
    }
}