using Picturra.Data.Contracts;
using System;

using Picturra.Models.Image;
using System.Data.SqlClient;

namespace Picturra.Data
{
    public class ImageUploadRepository : IImageUploadRepository
    {
        public SqlConnection SqlConnection { get; set; }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ImageUpload Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Set(ImageUpload entity)
        {
            return 0;
        }
    }
}
