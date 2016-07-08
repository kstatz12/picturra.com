using System;
using Picturra.Models.Profile;

namespace Picturra.Presenter.Adapters
{
    public interface IContactServiceAdapter : IServiceAdapter<Contact, Guid>
    {
        Contact Get(int id);
        void Delete(int id);
    }
}