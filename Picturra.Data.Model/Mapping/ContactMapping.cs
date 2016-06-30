using Picturra.Models.Profile;

namespace Picturra.Data.Model.Mapping
{
    public static class ContactMapping
    {
        public static Contact ToContact(this ContactInformation input)
        {
            return new Contact
            {
                Id = input.Id,
                LoginId = input.LoginId,
                AddressOne = input.AddressOne,
                AddressTwo = input.AddressTwo,
                Phone = input.PhoneNumber
            };
        }

        public static ContactInformation ToContactInformation(this Contact input)
        {
            return new ContactInformation
            {
                Id = input.Id,
                LoginId = input.LoginId,
                AddressOne = input.AddressOne,
                AddressTwo = input.AddressTwo,
                PhoneNumber = input.Phone
            };
        }
    }
}