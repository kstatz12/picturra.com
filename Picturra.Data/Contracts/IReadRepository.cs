using Picturra.Models;

namespace Picturra.Data.Contracts
{
    public interface IReadRepository<out T, in TId> : IRepository where T : IModelBase<TId>
    {
        T Get(TId id);
    }
}