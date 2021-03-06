﻿using Picturra.Models.Image;
using Picturra.Presenter.Adapters;


namespace Picturra.Presenter.Commands
{
    public class UploadImage : ICommand<ImageUpload, Image>
    {
        private readonly ICloudinaryAdapter _cloudinaryAdapter;
        public UploadImage(ICloudinaryAdapter cloudinaryAdapter)
        {
            _cloudinaryAdapter = cloudinaryAdapter;
        }
        public ImageUpload Input { get; set; }

        public Image Value { get; set; }

        public void Execute()
        {
            Value = _cloudinaryAdapter.UploadImage(Input);
        }
    }
}
