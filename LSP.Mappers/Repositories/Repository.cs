using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data;

namespace LSP.Mappers.Repositories
{
    using LSP.Models.Repositories;

    public abstract class Repository<TObject>
        : IRepository<TObject> where TObject : class
    {
        protected LspContext Context = null;
        private bool _shareContext = false;

        public Repository()
        {
            Context = new LspContext();
        }

        public Repository(LspContext context)
        {
            Context = context;
            _shareContext = true;
        }

        public virtual IQueryable<TObject> All()
        {
            return DbSet.AsQueryable();
        }

        public virtual IQueryable<TObject> Filter(Expression<Func<TObject, bool>> predicate)
        {
            return DbSet.Where(predicate).AsQueryable<TObject>();
        }

        public virtual IQueryable<TObject> Filter<Key>(Expression<Func<TObject, bool>> filter, 
            out int total, int index = 0, int size = 50)
        {
            int skipCount = index * size;
            var _resetSet = filter != null ? DbSet.Where(filter).AsQueryable() :
                DbSet.AsQueryable();
            _resetSet = skipCount == 0 ? _resetSet.Take(size) :
                _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        public virtual TObject Find(params object[] keys)
        {
            return DbSet.Find(keys);
        }

        public virtual TObject Find(Expression<Func<TObject, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public virtual IQueryable<TObject> GetByCriteria(TObject criteria)
        {
            throw new NotImplementedException();
        }

        public virtual int Count
        {
            get
            {
                return DbSet.Count();
            }
        }

        public int Insert(TObject model)
        {
            var newEntry = DbSet.Add(model);
            if (!_shareContext)
                Context.SaveChanges();

            return 0;
        }

        public int Update(TObject model)
        {
            var entry = Context.Entry(model);
            DbSet.Attach(model);
            entry.State = EntityState.Modified;
            if (!_shareContext)
                return Context.SaveChanges();

            return 0;
        }

        public int Delete(TObject model)
        {
            DbSet.Remove(model);
            if (!_shareContext)
                return Context.SaveChanges();

            return 0;
        }

        public void Dispose()
        {
            if (_shareContext && (Context != null))
                Context.Dispose();
        }

        protected DbSet<TObject> DbSet
        {
            get
            {
                return Context.Set<TObject>();
            }
        }
    }
}
