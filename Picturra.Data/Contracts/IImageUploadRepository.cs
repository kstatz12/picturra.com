using Picturra.Models.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Data.Contracts
{
    public interface IImageUploadRepository : IRepository<ImageUpload, int>
    {
        void Delete(int id);
    }
}
