using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Service.Picturra.com.ServiceModel
{
    [Route("/Contact", "GET")]
    [Route("/Contact/{LoginId}")]

    public class GetContact : IReturn<ContactResponse>
    {
        public Guid LoginId { get; set; }
    }

    [Route("/Contact", "GET")]
    [Route("/Contact/{Id}")]
    public class GetContactById : IReturn<ContactResponse>
    {
        public int Id { get; set; }
    }

    [Route("/Contact", "POST PUT")]
    [Route("/Contact/{LoginId}", "POST PUT")]
    public class UpdateContact : IReturn<ContactResponse>
    {
        public int Id { get; set; }
        public Guid LoginId { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
    }

    [Route("/Contact/{Id}", "DELETE")]
    public class DeleteContact
    {
        public int Id { get; set; }
    }

    public class ContactResponse
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
