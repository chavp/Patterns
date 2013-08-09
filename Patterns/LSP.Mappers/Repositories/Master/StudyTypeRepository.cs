using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Repositories.Master
{
    using LinqKit;
    using LSP.Models.Master;
    using LSP.Models.Repositories.Master;
    using System.Collections;
    using System.Linq.Expressions;

    public class StudyTypeRepository 
        : Repository<StudyType>, IStudyTypeRepository
    {
        internal StudyTypeRepository(LspContext context)
            : base(context)
        {
        }

        public StudyType Get(int id, string languageID)
        {
            return DbSet.Find(id, languageID);
        }

        public int GetNextOrder()
        {
            var maxOrder = GetMaxStudyTypeOrder();
            //Next Max Order
            ++maxOrder;
            return maxOrder;
        }

        public int GetNextId()
        {
            int? maxId = DbSet.Max(d => (int?)d.ID);
            return (maxId.HasValue) ? maxId.Value + 1 : 1;
        }

        public int GetMaxStudyTypeOrder()
        {
            var maxOrder = (from st in DbSet
                            select st.Order)
                            .Max().GetValueOrDefault();
            return maxOrder;
        }

        public IQueryable<StudyType> GetDuplicate(string studyTypeName, int? studyTypeID)
        {
            var whereCause = PredicateBuilder.True<StudyType>();
            whereCause = whereCause.And(st => st.Name == studyTypeName);

            if (studyTypeID.HasValue)
            {
                whereCause = whereCause.And(st => st.ID != studyTypeID);
            }

            return DbSet.AsExpandable().Where(whereCause);
        }

        public IQueryable<StudyType> GetBy(int? studyTypeID)
        {
            return (from st in DbSet
                    where st.ID == studyTypeID
                    select st);
        }

        public override IQueryable<StudyType> GetByCriteria(StudyType criteria)
        {
            // Dynamic where cause
            var whereCause = PredicateBuilder.True<StudyType>();

            if (criteria.ID > 0)
            {
                whereCause = whereCause.And(b => b.ID.Equals(criteria.ID));
            }

            if (!string.IsNullOrEmpty(criteria.Name))
            {
                whereCause = whereCause.And(b => b.Name.Contains(criteria.Name));
            }

            if (!string.IsNullOrEmpty(criteria.ActiveFlag))
            {
                whereCause = whereCause.And(b => b.ActiveFlag.Equals(criteria.ActiveFlag));
            }

            if (!string.IsNullOrEmpty(criteria.LanguageID))
            {
                whereCause = whereCause.And(b => b.LanguageID.Equals(criteria.LanguageID));
            }

            return DbSet.AsExpandable().Where(whereCause);
        }
    }
}
