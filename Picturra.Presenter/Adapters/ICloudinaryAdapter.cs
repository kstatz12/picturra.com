using CloudinaryDotNet;
using Picturra.Models.Image;

namespace Picturra.Presenter.Adapters
{
    public interface ICloudinaryAdapter
    {
        Account Credentials { get; set; }
        Image UploadImage(ImageUpload imageUpload);
        void DeleteImage(string token);
    }
}
