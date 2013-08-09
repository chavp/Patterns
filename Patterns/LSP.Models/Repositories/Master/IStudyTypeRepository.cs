using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Repositories.Master
{
    using LSP.Models.Master;

    public interface IStudyTypeRepository 
        : IRepository<StudyType>
    {
        StudyType Get(int id, string languageID);
        int GetNextOrder();
        int GetNextId();
        int GetMaxStudyTypeOrder();
        IQueryable<StudyType> GetDuplicate(string studyTypeName, int? studyTypeID);
        IQueryable<StudyType> GetBy(int? studyTypeID);
    }
}
