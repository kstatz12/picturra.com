using System;
using ServiceStack.DataAnnotations;

namespace Picturra.Data.Model
{
    public class Contact
    {
        [AutoIncrement]
        public int Id { get; set; }
        public Guid LoginId { get; set; }
        public string Phone { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
    }
}
