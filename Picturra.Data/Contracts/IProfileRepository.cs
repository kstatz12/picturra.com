using System;

namespace Picturra.Data.Contracts
{
    public interface IProfileRepository : IReadRepository<Models.Profile.Profile, int>, IWriteRepository<Models.Profile.Profile, int>
    {
        Models.Profile.Profile GetProfileByLoginId(Guid loginIdGuid);
    }
}