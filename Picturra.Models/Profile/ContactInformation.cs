using System;

namespace Picturra.Models.Profile
{
    public class ContactInformation : IModelBase<int>
    {
        public int Id { get; set; }
        public Guid LoginId { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
    }
}
