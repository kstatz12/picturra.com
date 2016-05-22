using System;

namespace Picturra.Models.Image
{
    public class ImageUpload
    { 
        public int Id { get; set; }
        public string Ip { get; set; }
        public Guid User { get; set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }
    }
}
