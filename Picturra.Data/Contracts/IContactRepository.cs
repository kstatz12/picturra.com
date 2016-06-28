using System;
using Picturra.Models;

namespace Picturra.Data.Contracts
{
    public interface IContactRepository<T, in TId> : IRepository where T : IModelBase<TId>
    {
        T GetContact(TId id);
        T GetContactByLoginId(Guid loginId);
        void UpdateContact(T entity);
        void DeleteContact(TId id);
    }
}
