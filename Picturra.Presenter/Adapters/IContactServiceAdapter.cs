using System;
using System.Security.Cryptography.X509Certificates;
using Picturra.Models.Profile;

namespace Picturra.Presenter.Adapters
{
    public interface IContactServiceAdapter : IServiceAdapter<ContactInformation, Guid>
    {
        ContactInformation Get(int id);
        void Delete(int id);
    }
}