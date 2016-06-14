using System;

namespace Picturra.Models.Profile
{
    public class Profile
    {
        public Profile()
        {
            Image = new Image.Image();
        }
        public int Id { get; set; }
        public Guid LogindId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public Image.Image Image { get; set; }
    }
}
