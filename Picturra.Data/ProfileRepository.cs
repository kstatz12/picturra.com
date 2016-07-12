using System.Data;
using Picturra.Data.Contracts;
using Picturra.Models.Data;
using Picturra.Models.Helpers;
using ServiceStack.OrmLite;


namespace Picturra.Data
{
    public class ProfileRepository : IProfileRepository
    {
        public OrmLiteConnectionFactory DbFactory { get; set; }
        private readonly IDbConnection _connection;

        public ProfileRepository(OrmLiteConnectionFactory dbFactory)
        {
            DbFactory = dbFactory;
            _connection = DbFactory.CreateDbConnection();
        }
        public Models.Profile.Profile GetProfileByLoginId(System.Guid loginIdGuid)
        {
            var profile = _connection.Single<Profile>(x => x.LoginId == loginIdGuid);
            return profile.ToProfile();
        }

        public Models.Profile.Profile Get(int id)
        {
            var profile = _connection.SingleById<Profile>(id);
            return profile.ToProfile();
        }

        public Models.Profile.Profile Save(Models.Profile.Profile entity)
        {
            var profile = entity.ToProfile();
            _connection.Insert(profile);
            return entity;
        }

        public Models.Profile.Profile Update(Models.Profile.Profile entity)
        {
            var profile = entity.ToProfile();
            _connection.Update(profile);
            return entity;
        }

        public void Delete(int id)
        {
            _connection.DeleteById<Profile>(id);
        }
    }
}