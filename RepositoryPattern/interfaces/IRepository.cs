using marsev.Models;
using System.Linq.Expressions;

namespace marsev.RepositoryPattern.interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(int id);

        List<T> GetByExpression(Expression<Func<T, bool>> exp);

        int Count();

        bool Any(Expression<Func<T, bool>> exp);

        List<T> SelectByLimit(int limit);

        T Default(Expression<Func<T, bool>> exp);
    }
}
