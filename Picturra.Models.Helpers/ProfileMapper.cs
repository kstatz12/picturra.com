using System.Data.Common;
using System.Runtime.CompilerServices;
using Picturra.Models.Data;

namespace Picturra.Models.Helpers
{
    public static class ProfileMapper
    {
        public static Data.Profile ToProfile(this Profile.Profile input)
        {
            return new Data.Profile
            {
                Id = input.Id,
                LoginId = input.LogindId,
                About = input.About,
                Name = input.Name,
                Image = input.Image.ToImage() as ProfileImage
            };
        }

        public static Profile.Profile ToProfile(this Data.Profile input)
        {
            return new Profile.Profile
            {
                Id = input.Id,
                LogindId = input.LoginId,
                About = input.About,
                Name = input.Name,
                Image = input.Image.Toimage()
            };
        }
         
    }
}