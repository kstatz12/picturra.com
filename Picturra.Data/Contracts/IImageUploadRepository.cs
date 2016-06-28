using Picturra.Models;

namespace Picturra.Data.Contracts
{
    public interface IImageUploadRepository<T, in TId> : IRepository where T : IModelBase<TId>
    {
        T Get(TId id);
        void Save(T entity);
        void Delete(TId id);
    }
}
