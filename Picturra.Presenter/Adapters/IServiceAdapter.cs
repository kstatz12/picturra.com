namespace Picturra.Presenter.Adapters
{
    public interface IServiceAdapter<T, in TId>
    {
        T Get(TId id);
        T Update(T entity);
        T Create(T entity);
        void Delete(TId id);
    }
}