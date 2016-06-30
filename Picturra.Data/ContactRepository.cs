using System;
using System.CodeDom;
using System.Data;
using System.Linq;
using Picturra.Data.Contracts;
using Picturra.Data.Model;
using Picturra.Models.Profile;
using Picturra.Data.Model.Mapping;
using ServiceStack.OrmLite;
namespace Picturra.Data
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnection _connection;

        public ContactRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public ContactInformation Get(int id)
        {
            var contact = _connection.Single<Contact>(x => x.Id == id);
            return contact != null ? contact.ToContactInformation() : new ContactInformation();
        }

        public ContactInformation Save(ContactInformation entity)
        {
            var contact = entity.ToContact();
            _connection.Insert<Contact>(contact);
            return entity;
        }

        public ContactInformation Update(ContactInformation entity)
        {
            var contact = entity.ToContact();
            _connection.Update<Contact>(contact);
            return entity;
        }

        public void Delete(int id)
        {
            _connection.Delete(id);
        }

        public ContactInformation GetContactByLoginId(Guid loginId)
        {
            var contact = _connection.Single<Contact>(x => x.LoginId == loginId);
            return contact != null ? contact.ToContactInformation() : new ContactInformation();
        }

        public void DeleteContactByLoginId(Guid id)
        {
            _connection.Delete(id);
        }
    }
}
