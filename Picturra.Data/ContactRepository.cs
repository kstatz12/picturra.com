using System;
using System.Data;
using Picturra.Data.Contracts;
using Picturra.Models.Helpers;
using ServiceStack.OrmLite;

namespace Picturra.Data
{
    public class ContactRepository : IContactRepository
    {
        public OrmLiteConnectionFactory DbFactory { get; set; }

        private readonly IDbConnection _connection;
        public ContactRepository(OrmLiteConnectionFactory dbFactory)
        {
            DbFactory = dbFactory;
            _connection = dbFactory.CreateDbConnection();
        }
        public Models.Profile.Contact Get(int id)
        {
            var contact = _connection.Single<Models.Data.Contact>(x => x.Id == id);
            
            return contact != null ? contact.ToContact() : new Models.Profile.Contact();
        }

        public Models.Profile.Contact Save(Models.Profile.Contact entity)
        {
            var contact = entity.ToContact();
            _connection.Insert(contact);
            return entity;
        }

        public Models.Profile.Contact Update(Models.Profile.Contact entity)
        {
            var contact = entity.ToContact();
            _connection.Update(contact);
            return entity;
        }

        public void Delete(int id)
        {
            _connection.Delete(id);
        }

        public Models.Profile.Contact GetContactByLoginId(Guid loginId)
        {
            var contact = _connection.Single<Models.Data.Contact>(x => x.LoginId == loginId);
            return contact != null ? contact.ToContact() : new Models.Profile.Contact();
        }

        public void DeleteContactByLoginId(Guid id)
        {
            _connection.Delete(id);
        }


    }
}
