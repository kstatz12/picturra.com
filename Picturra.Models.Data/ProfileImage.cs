using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class ProfileImage : DataImage
    {
        [ForeignKey(typeof(Profile))]
        public int ProfileId { get; set; }
    }
}
