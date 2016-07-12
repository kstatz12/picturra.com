using System;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public interface IDataImage
    {
        [AutoIncrement]
        [PrimaryKey]
        int Id { get; set; }
        [Required]
        string Url { get; set; }
        string Caption { get; set; }
        [Required]
        string PublicKey { get; set; }
        [Required]
        Guid CreatedBy { get; set; }
        [Required]
        DateTime CreatedDate { get; set; }
    }
}