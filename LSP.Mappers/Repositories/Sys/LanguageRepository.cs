using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Repositories.Sys
{
    using LinqKit;
    using LSP.Models.Repositories.Sys;
    using LSP.Models.Sys;

    public class LanguageRepository
        : Repository<Language>, ILanguageRepository
    {
        internal LanguageRepository(LspContext context) 
            : base(context)
        {
           
        }

        public IEnumerable<Language> GetActiveLanguage()
        {
            return this.Filter( l => l.ActiveFlag == "Y");
        }

        public override IQueryable<Language> GetByCriteria(Language criteria)
        {
            // Dynamic where cause
            var whereCause = PredicateBuilder.True<Language>();

            if (!string.IsNullOrEmpty(criteria.ActiveFlag))
            {
                whereCause = whereCause.And(b => b.ActiveFlag.Equals(criteria.ActiveFlag));
            }

            if (!string.IsNullOrEmpty(criteria.ID))
            {
                whereCause = whereCause.And(b => b.ID.Equals(criteria.ID));
            }

            return DbSet.AsExpandable().Where(whereCause);
        }
    }
}
