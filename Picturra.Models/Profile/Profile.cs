using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturra.Models.Profile
{
    public class Profile
    {
        public Profile()
        {
            Image = new Image.Image();
            Portfolio = new Porftolio();
        }
        public int Id { get; set; }
        public Guid LogindId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public Image.Image Image { get; set; }
        public Porftolio Portfolio { get; set; }
    }
}
