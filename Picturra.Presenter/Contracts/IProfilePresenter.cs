using System;
using Picturra.Models.Data;

namespace Picturra.Presenter.Contracts
{
    public interface IProfilePresenter
    {
        void CreateContact(Models.Profile.Contact contact);
        Models.Profile.Contact GetContact(Guid loginId);
        void DeleteContact(Guid loginId);
        void UpdateContact(Models.Profile.Contact contact);
    }
}