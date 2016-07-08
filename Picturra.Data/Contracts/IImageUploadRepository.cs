using Picturra.Models;
using Picturra.Models.Image;

namespace Picturra.Data.Contracts
{
    public interface IImageUploadRepository : IWriteRepository<ImageUpload, int>
    {
        
    }
}
