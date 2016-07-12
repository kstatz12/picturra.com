using System.Linq;
using Picturra.Models.Data;

namespace Picturra.Models.Helpers
{
    public static class PortfolioMapper
    {
        public static Portfolio ToPortfolio(this Profile.Porftolio input)
        {
            return new Portfolio
            {
                Id = input.Id,
                LoginId = input.LoginId,
                Statement = input.Statement,
                Series = input.SeriesCollection.Select(x=>x.ToSeries()).ToList()
            };
        }

        public static Profile.Porftolio ToPorftolio(this Portfolio input)
        {
            return new Profile.Porftolio
            {
                Id = input.Id,
                LoginId = input.LoginId,
                Statement = input.Statement,
                SeriesCollection = input.Series.Select(x => x.ToSeries()).ToList()
            };
        }
    }
}