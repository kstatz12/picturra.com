using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Models.Image
{
    public class Image
    {
        public string Url { get; set; }
        public string Caption { get; set; }
        public string PublicKey { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
