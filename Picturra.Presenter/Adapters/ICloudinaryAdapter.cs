using CloudinaryDotNet;
using Picturra.Models.Image;
using Picturra.Models.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Presenter.Adapters
{
    public interface ICloudinaryAdapter
    {
        Account Credentials { get; set; }
        Image UploadImage(ImageUpload imageUpload);
        void DeleteImage(string token);
    }
}
