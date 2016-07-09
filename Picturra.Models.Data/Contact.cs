using System;
using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class Contact
    {
        [AutoIncrement]
        [PrimaryKey   ]
        public int Id { get; set; }
        [Required]
        public Guid LoginId { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
    }
}
