using System;
using Picturra.Helpers.cs;
using Picturra.Models.Helpers;
using Picturra.Models.Profile;
using RestSharp;
using Service.Picturra.com.ServiceModel;
namespace Picturra.Presenter.Adapters
{
    public class ContactServiceAdapter : IContactServiceAdapter
    {
        private readonly RestClient _client;

        public ContactServiceAdapter()
        {
            var baseUrl = ConfigurationHelper.GetContactServiceHost();
            _client = new RestClient { BaseUrl = new Uri(baseUrl) };
        }

        public Contact Get(Guid id)
        {
            var request = new RestRequest("Contact/{LoginId}", Method.GET);
            request.AddParameter("LoginId", id);
            return _client.Execute<ContactResponse>(request).Data
                          .ToContact();
        }

        public Contact Get(int id)
        {
            var request = new RestRequest("Contact/{Id}", Method.GET);
            request.AddParameter("Id", id);
            return _client.Execute<ContactResponse>(request).Data
                          .ToContact();
        }

        public Contact Update(Contact entity)
        {
            var req = string.Format("Contact/");
            var request = new RestRequest(req, Method.PUT)
            {
                RequestFormat = DataFormat.Json,
            };
            var postBody = entity;
            request.AddBody(postBody);
            return _client.Execute<ContactResponse>(request).Data
                          .ToContact();
        }

        public Contact Create(Contact entity)
        {
            var request = new RestRequest("Contact/", Method.POST)
            {
                RequestFormat = DataFormat.Json,
            };
            var postBody = entity.ToContactResponse();
            request.AddBody(postBody);
            return _client.Execute<ContactResponse>(request).Data
                          .ToContact();
        }

        public void Delete(int id)
        {
            var request = new RestRequest("Contact/{Id}", Method.DELETE);
            request.AddParameter("Id", id);
            _client.Execute(request);
        }

        public void Delete(Guid id)
        {
            var request = new RestRequest("Contact/{LogindId}", Method.DELETE);
            request.AddParameter("LoginId", id);
            _client.Execute(request);
        }
    }
}