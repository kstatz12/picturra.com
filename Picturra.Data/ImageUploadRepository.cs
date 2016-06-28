using Picturra.Data.Contracts;
using System;

using Picturra.Models.Image;
using System.Data.SqlClient;

namespace Picturra.Data
{
    public class ImageUploadRepository : IImageUploadRepository<ImageUpload, int>
    {
        public SqlConnection SqlConnection { get; set; }

        public ImageUpload Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(ImageUpload entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
