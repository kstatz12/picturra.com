using System.Collections.Generic;


namespace Picturra.Models.Profile
{
    public class Porftolio : IModelBase<int>
    {
        public int Id { get; set; }
        public string Statement { get; set; }
        public List<Series> SeriesCollection { get; set; } 
    }
}
