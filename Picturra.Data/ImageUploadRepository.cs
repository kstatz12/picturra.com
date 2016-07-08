using System.Data;
using Picturra.Data.Contracts;
using Picturra.Models.Helpers;
using Picturra.Models.Image;
using ServiceStack.OrmLite;

namespace Picturra.Data
{
    public class ImageUploadRepository : IImageUploadRepository
    {
        public OrmLiteConnectionFactory DbFactory { get; set; }
        private readonly IDbConnection _connection;
        public ImageUploadRepository(OrmLiteConnectionFactory dbFactory)
        {
            DbFactory = dbFactory;
            _connection = DbFactory.CreateDbConnection();
        }
        public ImageUpload Save(ImageUpload entity)
        {
            var imageUpload = entity.ToImageUpload();
            _connection.Insert(imageUpload);
            return entity;
        }

        public ImageUpload Update(ImageUpload entity)
        {
            var imageUpload = entity.ToImageUpload();
            _connection.Update(imageUpload);
            return entity;
        }

        public void Delete(int id)
        {
            _connection.Delete(id);
        }
    }
}
