using marsev.Context;
using marsev.Models;
using marsev.RepositoryPattern.interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace marsev.RepositoryPattern.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        MMDbContext _db;
        protected DbSet<T> table;

        private void Save()
        {
            _db.SaveChanges();
        }
        public Repository(MMDbContext db) {
            _db = db;
            table = db.Set<T>();
             
            
        }
        public void Add(T entity)
        {
            table.Add(entity);
            Save();
            
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return table.Any(exp);
        }

        public int Count()
        {
            return table.Count();
        }

        public void Delete(int id)
        {
            T entity = GetById(id);
            table.Remove(entity);
            Save();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public List<T> GetByExpression(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public List<T> SelectByLimit(int limit)
        {
            return table.Take(limit).ToList();
        }

        public void Update(T entity)
        {
            table.Update(entity);
            Save();
        }

        public T Default(Expression<Func<T, bool>> exp)
        {
            return table.FirstOrDefault(exp);
        }
    }
}
