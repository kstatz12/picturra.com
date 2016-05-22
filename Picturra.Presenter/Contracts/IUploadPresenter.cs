using Picturra.Models.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Presenter.Contracts
{
    public interface IUploadPresenter
    {
        Image UploadImage(ImageUpload imageUpload);
        void DeleteImage(string publicKey);
    }
}
