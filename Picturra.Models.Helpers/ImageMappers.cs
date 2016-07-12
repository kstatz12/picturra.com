using Picturra.Models.Data;

namespace Picturra.Models.Helpers
{
    public static class ImageMappers
    {
        public static Image.Image Toimage<T>(this T input) where T : IDataImage
        {
            return new Image.Image
            {
                Id = input.Id,
                Caption = input.Caption,
                PublicKey = input.Caption,
                CreatedDate = input.CreatedDate,
                CreatedBy = input.CreatedBy,
                Url = input.Url
            };
        }

        public static IDataImage ToImage(this  Image.Image input)
        {
            return new DataImage
            {
                Id = input.Id,
                Caption = input.Caption,
                PublicKey = input.Caption,
                CreatedDate = input.CreatedDate,
                CreatedBy = input.CreatedBy,
                Url = input.Url
            };
        }
    }
}