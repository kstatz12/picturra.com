using System;

namespace Picturra.Models.Profile
{
    public class Contact : IModelBase<int>
    {
        public int Id { get; set; }
        public Guid LoginId { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
    }
}
