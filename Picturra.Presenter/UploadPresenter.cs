using System;
using Picturra.Models.Image;
using Picturra.Presenter.Contracts;
using Picturra.Presenter.Commands;
using Picturra.Presenter.Adapters;

namespace Picturra.Presenter
{
    public class UploadPresenter : IUploadPresenter
    {
        private readonly ICommandInvoker _commandInvoker;
        private readonly ICloudinaryAdapter _cloudinaryAdapter;
        public UploadPresenter(ICommandInvoker commandInvoker, ICloudinaryAdapter cloudinaryAdapter)
        {
            _commandInvoker = commandInvoker;
            _cloudinaryAdapter = cloudinaryAdapter;
        }

        public void DeleteImage(string publicKey)
        {
            _commandInvoker.Invoke(new DeleteImage(_cloudinaryAdapter), publicKey);
        }

        public Image UploadImage(ImageUpload imageUpload)
        {
            return _commandInvoker.Invoke(new UploadImage(_cloudinaryAdapter), imageUpload);
        }
    }
}
