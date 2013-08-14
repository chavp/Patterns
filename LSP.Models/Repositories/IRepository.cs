using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LSP.Models.Repositories
{
    public interface IRepository<TDataModel>
        : IDisposable where TDataModel : class 
    {
        /// <summary>
        /// Gets all objects from database
        /// </summary>
        IQueryable<TDataModel> All();

        /// <summary>
        /// Gets objects from database by filter.
        /// </summary>
        /// <param name="predicate">Specified a filter</param>
        IQueryable<TDataModel> Filter(Expression<Func<TDataModel, bool>> predicate);

        /// <summary>
        /// Gets objects from database with filting and paging.
        /// </summary>
        /// <typeparam name="Key"></typeparam>
        /// <param name="filter">Specified a filter</param>
        /// <param name="total">Returns the total records count of the filter.</param>
        /// <param name="index">Specified the page index.</param>
        /// <param name="size">Specified the page size</param>
        IQueryable<TDataModel> Filter<Key>(Expression<Func<TDataModel, bool>> filter,
            out int total, int index = 0, int size = 50);

        /// <summary>
        /// Get the total objects count.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Find object by keys.
        /// </summary>
        /// <param name="keys">Specified the search keys.</param>
        TDataModel Find(params object[] keys);

        /// <summary>
        /// Find object by specified expression.
        /// </summary>
        /// <param name="predicate"></param>
        TDataModel Find(Expression<Func<TDataModel, bool>> predicate);

        IQueryable<TDataModel> GetByCriteria(TDataModel criteria);

        int Insert(TDataModel model);

        int Update(TDataModel model);

        int Delete(TDataModel model);
        
    }
}
