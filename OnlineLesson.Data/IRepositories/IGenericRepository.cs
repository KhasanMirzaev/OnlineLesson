using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLesson.Data.IRepositories
{
    public interface IGenericRepository<TSource> where TSource : class
    {
        TSource Create(TSource entity);
        bool Delete(Expression<Func<TSource, bool>> predicate);
        TSource Get(Expression<Func<TSource, bool>> predicate);
        IQueryable<TSource> GetAll(Expression<Func<TSource, bool>> predicate = null);
        TSource Update(int Id, TSource entity);  
    }
}
