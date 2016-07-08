using System;
using System.IO;

namespace Picturra.Models.Image
{
    public class ImageUpload : IModelBase<int>
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public Guid LoginId { get; set; }
        public Stream File { get; set; }
        public string FileName { get; set; }

    }
}
