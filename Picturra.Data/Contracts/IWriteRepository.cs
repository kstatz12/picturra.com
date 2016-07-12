using Picturra.Models;

namespace Picturra.Data.Contracts
{
    public interface IWriteRepository<T, in TId> : IRepository where T : IModelBase<TId>
    {
        T Save(T entity);
        T Update(T entity);
        void Delete(TId id);
    }

    public interface IWriteRepository<T> : IRepository
    {
        T Save(T entity);
        T Update(T entity);
        void Delete(int Id);
    }
}