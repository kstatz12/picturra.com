using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Picturra.Models.Image;
using CloudinaryDotNet;
using Picturra.Presenter.Adapters.Helpers;
using CloudinaryDotNet.Actions;
using System.IO;
using Picturra.Data.Contracts;

namespace Picturra.Presenter.Adapters
{
    public class CloudinaryAdapter : ICloudinaryAdapter
    {
        private readonly IImageUploadRepository<ImageUpload, int> _imageUploadRepository;
        public CloudinaryAdapter(IImageUploadRepository<ImageUpload, int> imageUploadRepository)
        {
            Credentials = CloudinaryAccountFactory.Create();
            _imageUploadRepository = imageUploadRepository;
        }
        public Account Credentials { get; set; }

        public void DeleteImage(string token)
        {
            var cloudinary = new Cloudinary(Credentials);
            var paramCollection = new string[]{
                token
            };
            cloudinary.DeleteResources(paramCollection);
        }

        public Image UploadImage(ImageUpload imageUpload)
        {
            var cloudinary = new Cloudinary(Credentials);
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(imageUpload.FileName, imageUpload.File)
            };
            var uploadResult = cloudinary.Upload(uploadParams);
            _imageUploadRepository.Set(imageUpload);
            return new Image
            {
                Url = uploadResult.Uri.ToString(),
            };
        }
    }
}
