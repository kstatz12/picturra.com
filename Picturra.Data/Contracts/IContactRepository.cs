using System;
using Picturra.Models.Profile;

namespace Picturra.Data.Contracts
{
    public interface IContactRepository : IReadRepository<Contact, int>, IWriteRepository<Contact, int>
    {
        Contact GetContactByLoginId(Guid loginId);
        void DeleteContactByLoginId(Guid id);
    }
}
