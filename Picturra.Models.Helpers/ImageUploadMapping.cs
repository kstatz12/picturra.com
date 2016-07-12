using System;
using Picturra.Models.Data;

namespace Picturra.Models.Helpers
{
    public static class ImageUploadMapping
    {
        public static Image.ImageUpload ToImageUpload(this ImageUpload input)
        {
            return new Image.ImageUpload
            {
                Id = input.Id,
                LoginId = input.LoginId,
                FileName = input.FileName,
                Ip = input.Ip
            };
        }

        public static ImageUpload ToImageUpload(this Image.ImageUpload input)
        {
            return new ImageUpload
            {
                Id = input.Id,
                LoginId = input.LoginId,
                CreatedDate = DateTime.Now,
                FileName = input.FileName,
                Ip = input.Ip
            };
        }
    }
}
