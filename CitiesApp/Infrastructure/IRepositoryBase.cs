using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CitiesApp.Infrastructure
{
    public interface IRepositoryBase<T> where T : class
    {
        T Add(T t);
        Task<T> AddAsyn(T t);
        void Delete(T entity);
        Task<int> DeleteAsyn(T entity);
        Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate);
        Task<T> FirtsOrDefaoultAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetListOrderBy(Expression<Func<T, string>> predicate);
        List<T> GetAll();
        Task<ICollection<T>> GetAllAsyn();
        Task<T> GetAsync(int? id);
        void Save();
        void Update(T entity);
        Task<int> SaveAsync();
        Task<int> UpdateAsync(T entity);
        IQueryable<T> GetAllSelect(Expression<Func<T, T>> predicate);
    }
}
