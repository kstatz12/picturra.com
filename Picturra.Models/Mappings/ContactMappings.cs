using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Picturra.Models.Profile;
using Service.Picturra.com.ServiceModel;

namespace Picturra.Models.Mappings
{
    public static class ContactMappings
    {
        public static ContactInformation ToContactInformation(this ContactResponse contactResponse)
        {
            return new ContactInformation
            {
                AddressOne = contactResponse.AddressOne,
                AddressTwo = contactResponse.AddressTwo,
                Id = contactResponse.Id,
                LoginId = contactResponse.LoginId,
                PhoneNumber = contactResponse.Phone
            };
        }

        public static ContactResponse ToContactResponse(this ContactInformation contactInformation)
        {
            return new ContactResponse
            {
                AddressTwo = contactInformation.AddressTwo,
                AddressOne = contactInformation.AddressOne,
                Id = contactInformation.Id,
                LoginId = contactInformation.LoginId,
                Phone = contactInformation.PhoneNumber
            };
        }
    }
}
