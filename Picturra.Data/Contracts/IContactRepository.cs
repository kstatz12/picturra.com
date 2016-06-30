using System;
using Picturra.Models;
using Picturra.Models.Profile;

namespace Picturra.Data.Contracts
{
    public interface IContactRepository : IReadRepository<ContactInformation, int>, IWriteRepository<ContactInformation, int>
    {
        ContactInformation GetContactByLoginId(Guid loginId);
        void DeleteContactByLoginId(Guid id);
    }
}
