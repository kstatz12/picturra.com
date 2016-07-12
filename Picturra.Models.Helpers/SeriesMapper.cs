using System.Security.Cryptography;
using Picturra.Models.Data;

namespace Picturra.Models.Helpers
{
    public static class SeriesMapper
    {
        public static Profile.Series ToSeries(this Series input)
        {
            return new Profile.Series
            {
                Id = input.Id,
                Description = input.Description
            };
        }

        public static Series ToSeries(this Profile.Series input)
        {
            return new Series
            {
                Id = input.Id,
                Description = input.Description
            };
        }
                
    }
}