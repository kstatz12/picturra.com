using System.Data;
using Picturra.Data.Contracts;
using Picturra.Models.Helpers;
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
        public Models.Image.ImageUpload Save(Models.Image.ImageUpload  entity)
        {
            var imageUpload = entity.ToImageUpload();
            _connection.Insert(imageUpload);
            return entity;
        }

        public Models.Image.ImageUpload Update(Models.Image.ImageUpload entity)
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
