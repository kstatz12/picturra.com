using ServiceStack.DataAnnotations;

namespace Picturra.Models.Data
{
    public class SeriesTitleImage : DataImage
    {
        [ForeignKey(typeof(Series))]
        public int SeriesId { get; set; }
    }
}