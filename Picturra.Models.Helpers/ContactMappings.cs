using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Picturra.Models.Profile;
using Service.Picturra.com.ServiceModel;

namespace Picturra.Models.Helpers
{
    public static class ContactMappings
    {
        public static Contact ToContact(this ContactResponse input)
        {
            return new Contact
            {
                Id = input.Id,
                LoginId = input.LoginId,
                EmailAddress = input.EmailAddress,
                Phone = input.Phone,
                Twitter = input.Twitter,
                Instagram = input.Instagram,
                Facebook = input.Facebook
            };
        }

        public static ContactResponse ToContactResponse(this Contact input)
        {
            return new ContactResponse
            {
                Id = input.Id,
                LoginId = input.LoginId,
                EmailAddress = input.EmailAddress,
                Phone = input.Phone,
                Twitter = input.Twitter,
                Instagram = input.Instagram,
                Facebook = input.Facebook
            };
        }

        public static Data.Contact ToContact(this Contact input)
        {
            return new Data.Contact
            {
                Id = input.Id,
                LoginId = input.LoginId,
                EmailAddress = input.EmailAddress,
                Phone = input.Phone,
                Twitter = input.Twitter,
                Instagram = input.Instagram,
                Facebook = input.Facebook
            };
        }

        public static Contact ToContact(this Data.Contact input)
        {
            return new Contact
            {
                Id = input.Id,
                LoginId = input.LoginId,
                EmailAddress = input.EmailAddress,
                Phone = input.Phone,
                Twitter = input.Twitter,
                Instagram = input.Instagram,
                Facebook = input.Facebook
            };
        }
    }
}
