using ConnectDB.Models;

namespace ConnectDB.Interfaces
{
    public interface IRepository<T, TKey>
        where T : class
    {
        bool Create(T toInsert);
        bool Delete(TKey id);
        List<T> GetAll();
        T GetOne(TKey id);
        bool Update(T toUpdate);
    }
}